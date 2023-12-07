using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Pipel;

namespace FormsSample
{
    public partial class frmMain : Form
    {
        private const string InfosFileName = "infos.txt";

        public frmMain()
        {
            InitializeComponent();
            Read_Infos();
        }

        // Starting
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkActive.Checked)
            {
                PipelEngine.Start(txtName.Text);
                PipelEngine.Receive += PipeMessageReceived;
            }
            else
            {
                if(PipelEngine.Status)
                {
                    PipelEngine.Stop();
                    PipelEngine.Receive -= PipeMessageReceived;
                }
            }
        }

        // Pipe Message Received
        private void PipeMessageReceived(PipelMessage message)
        {
            try
            {
                if(this.InvokeRequired)
                {
                    this.Invoke(new MessageDelegate(PipeMessageReceived), message);
                }
                else
                {
                    PipeCommand cm = message.ConvertLoad<PipeCommand>();
                    //PipeCommand cm = PipeCommand.GetCommand(message);

                    if(cm.Type == PipeMessageTypes.TakePhoto)
                        txtMessages.AppendText(DateTime.Now.ToLongTimeString() + ":(Object) " + cm.ConvertLoad<List<int>>() + Environment.NewLine);
                    else if(cm.Type == PipeMessageTypes.ShowMessage)
                        txtMessages.AppendText(DateTime.Now.ToLongTimeString() + ":(Text) " + cm.Load + Environment.NewLine);
                }
            }
            catch(Exception ex)
            {
                txtMessages.AppendText(ex.Message + Environment.NewLine);
            }
        }
        
        // Send a Text Message
        private void btnSend_Click(object sender, EventArgs e)
        {
            PipeCommand.Send(PipeMessageTypes.ShowMessage, txtMesssage.Text, txtReceiverName.Text);
        }
        
        //Send a Object
        private void btnSendObject_Click(object sender, EventArgs e)
        {
            new PipeCommand(PipeMessageTypes.TakePhoto, new List<int> { 125, 138, 245 }).Send(txtReceiverName.Text);
        }


        #region Helpers

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnSave.PerformClick();
        }
        private void Read_Infos()
        {
            try
            {
                if(File.Exists(InfosFileName))
                {
                    string[] infos = File.ReadAllText(InfosFileName).Split(';');

                    if(infos.Length == 2)
                    {
                        txtName.Text = infos[0];
                        txtReceiverName.Text = infos[1];
                    }
                }
            }
            catch
            {

            }
        }
        private void btnNameCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((Control)sender).Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(InfosFileName, txtName.Text + ";" + txtReceiverName.Text);
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            chkActive.Checked = false;

            txtAddress.Text = "\\\\.\\pipe\\" + txtName.Text;
            txtReceiverName.Text = txtName.Text;
        }

        #endregion

    }
}
