namespace FormsSample
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesssage = new System.Windows.Forms.TextBox();
            this.txtReceiverName = new System.Windows.Forms.TextBox();
            this.btnSendObject = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddressCopy = new System.Windows.Forms.Button();
            this.btnNameCopy = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMesssage);
            this.groupBox2.Controls.Add(this.txtReceiverName);
            this.groupBox2.Controls.Add(this.btnSendObject);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Location = new System.Drawing.Point(326, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alıcı İsim";
            // 
            // txtMesssage
            // 
            this.txtMesssage.AcceptsReturn = true;
            this.txtMesssage.AcceptsTab = true;
            this.txtMesssage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMesssage.Location = new System.Drawing.Point(8, 45);
            this.txtMesssage.Multiline = true;
            this.txtMesssage.Name = "txtMesssage";
            this.txtMesssage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMesssage.Size = new System.Drawing.Size(250, 41);
            this.txtMesssage.TabIndex = 1;
            this.txtMesssage.Text = "Test message";
            // 
            // txtReceiverName
            // 
            this.txtReceiverName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiverName.Location = new System.Drawing.Point(58, 19);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(200, 20);
            this.txtReceiverName.TabIndex = 1;
            this.txtReceiverName.Text = "Server";
            // 
            // btnSendObject
            // 
            this.btnSendObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendObject.Location = new System.Drawing.Point(8, 92);
            this.btnSendObject.Name = "btnSendObject";
            this.btnSendObject.Size = new System.Drawing.Size(75, 23);
            this.btnSendObject.TabIndex = 2;
            this.btnSendObject.Text = "Send Object";
            this.btnSendObject.UseVisualStyleBackColor = true;
            this.btnSendObject.Click += new System.EventHandler(this.btnSendObject_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(183, 92);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.AcceptsReturn = true;
            this.txtMessages.AcceptsTab = true;
            this.txtMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessages.BackColor = System.Drawing.Color.Black;
            this.txtMessages.ForeColor = System.Drawing.Color.Silver;
            this.txtMessages.Location = new System.Drawing.Point(12, 142);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new System.Drawing.Size(578, 167);
            this.txtMessages.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnAddressCopy);
            this.groupBox1.Controls.Add(this.btnNameCopy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 124);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkActive.Location = new System.Drawing.Point(6, 19);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(62, 17);
            this.chkActive.TabIndex = 0;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(58, 66);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(190, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddressCopy
            // 
            this.btnAddressCopy.Location = new System.Drawing.Point(254, 66);
            this.btnAddressCopy.Name = "btnAddressCopy";
            this.btnAddressCopy.Size = new System.Drawing.Size(45, 20);
            this.btnAddressCopy.TabIndex = 2;
            this.btnAddressCopy.Text = "Copy";
            this.btnAddressCopy.UseVisualStyleBackColor = true;
            this.btnAddressCopy.Click += new System.EventHandler(this.btnNameCopy_Click);
            // 
            // btnNameCopy
            // 
            this.btnNameCopy.Location = new System.Drawing.Point(254, 40);
            this.btnNameCopy.Name = "btnNameCopy";
            this.btnNameCopy.Size = new System.Drawing.Size(45, 20);
            this.btnNameCopy.TabIndex = 2;
            this.btnNameCopy.Text = "Copy";
            this.btnNameCopy.UseVisualStyleBackColor = true;
            this.btnNameCopy.Click += new System.EventHandler(this.btnNameCopy_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 321);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Pipel Comm. Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesssage;
        private System.Windows.Forms.TextBox txtReceiverName;
        private System.Windows.Forms.Button btnSendObject;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddressCopy;
        private System.Windows.Forms.Button btnNameCopy;
    }
}

