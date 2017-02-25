namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Generic;

    internal class Storage : ModuleTemplate
    {
        private List<Helpers.OfflineFile> files = new List<Helpers.OfflineFile>();

        internal override void LoopAction()
        {
            //IMPLEMENT Storage LoopAction
            throw new NotImplementedException();
        }

        internal override void Shutdown()
        {
            //IMPLEMENT Storage Shutdown
            throw new NotImplementedException();
        }
    }
}
