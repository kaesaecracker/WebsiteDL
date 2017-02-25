namespace WebsiteDownloader.Helpers
{
    internal enum TaskStatus
    {
        UNSET = 0, // = DEFAULT VALUE, not yet queued
        ENQUEUED, // = waiting for finished worker thread
        INPROGRESS, // = download in progress
        FINISHED, // = download finished
        ERROR
    }
}
