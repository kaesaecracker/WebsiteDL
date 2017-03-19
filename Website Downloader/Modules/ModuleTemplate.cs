namespace WebsiteDownloader.Modules
{
    using System;
    using System.Threading;

    internal abstract class ModuleTemplate
    {
        private Thread runThread = null;

        // true if paused
        protected internal bool Paused { get; protected set; } = false;

        // true if running
        protected internal bool Running { get; protected set; } = false;

        // true if module is stopped completely
        protected internal bool Exited { get; protected set; } = false;

        // call once to start loop in new thread
        internal virtual void Start()
        {
            if (this.runThread == null)
            {
                this.runThread = new Thread(() => this.Loop());
                this.runThread.Name = "ModuleThread";
                this.runThread.Start();

                this.Running = true;
            }
            else
            {
                throw new InvalidOperationException("Module already running");
            }

            this.AfterStart();
        }

        // stops enqueueing more tasks, but still keeps everything in memory etc
        internal void Pause()
        {
            if (this.Running && !this.Paused)
            {
                this.Paused = true;
            }
            else
            {
                throw new InvalidOperationException("Already paused or not running");
            }
        }

        // resumes queueing
        internal void Resume()
        {
            if (this.Running && this.Paused)
            {
                this.Paused = false;
            }
            else
            {
                throw new InvalidOperationException("Not paused or not running");
            }
        }

        internal void Stop()
        {
            if (this.Running)
            {
                this.Running = false;
                this.AfterStop();
                this.runThread = null;
            }
            else
            {
                throw new InvalidOperationException("Not running");
            }
        }

        internal void Loop()
        {
            this.Running = true;

            while (this.Running)
            {
                if (!this.Paused)
                {
                    this.LoopAction();
                }
            }

            this.Running = false;
            this.Exited = true;
        }

        // Called in every loop, main module functionality that runs in extra thread goes here
        internal abstract void LoopAction();

        // waits for everything to stop
        internal abstract void WaitForShutdown();

        // run immediately after Start()
        protected internal virtual void AfterStart()
        {
        }

        // Called immediately after Stop()
        protected internal virtual void AfterStop()
        {
        }
    }
}
