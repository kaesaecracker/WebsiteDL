namespace WebsiteDownloader.Modules
{
    using System.Threading;

    internal abstract class ModuleTemplate
    {
        private Thread runThread = null;

        internal bool ShouldStop { get; set; } = false;

        internal bool Running { get; set; } = false;

        internal void Start()
        {
            if (this.runThread == null)
            {
                this.runThread = new Thread(this.Loop);
                Running = true;
            }
            else
            {
                throw new System.InvalidOperationException("Module already running");
            }
        }

        internal void Loop()
        {
            this.Running = true;

            while (!this.ShouldStop)
            {
                this.LoopAction();

                if (this.ShouldStop)
                {
                    this.Stop();
                }
            }

            this.Running = false;
        }

        internal abstract void LoopAction();

        internal abstract void Stop();
    }
}
