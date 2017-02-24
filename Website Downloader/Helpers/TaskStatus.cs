namespace WebsiteDownloader.Helpers
{
    internal enum TaskStatus
    {
        UNSET = 0, // = DEFAULT VALUE, not yet queued
        QUEUED, // = waiting for finished worker thread
        WORKING, // = download in progress
        FINISHED, // = download finished
        ERROR
    }
}
