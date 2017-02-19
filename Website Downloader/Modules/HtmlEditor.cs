using System;
using System.Collections.Concurrent;

namespace WebsiteDownloader.Modules
{
    class HtmlEditor : ModuleTemplate
    {
        internal ConcurrentQueue<Helpers.OfflineFile> Jobs { get; private set; } = new ConcurrentQueue<Helpers.OfflineFile>();

        internal override void LoopAction()
        {
            throw new NotImplementedException();
        }

        internal override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
