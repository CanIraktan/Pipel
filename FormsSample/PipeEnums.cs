namespace Pipel
{
    public enum PipeMessageTypes
    {
        ErrorOccured, // Error Type + Detailed text
        AppOpened, // Name + Version + Opening time
        AppClosed, // Name + Version + Working time
        CloseApp, // Null
        TakePhoto, // Null
        ShowMessage, // Message text
        Lock // Null or Duration
    }
}