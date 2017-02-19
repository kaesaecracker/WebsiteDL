namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Generic;

    internal class Storage : ModuleTemplate
    {
        private List<Helpers.OfflineFile> files = new List<Helpers.OfflineFile>();

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
