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
                this.runThread.Start();

                this.Running = true;
            }
            else
            {
                throw new InvalidOperationException("Module already running");
            }

            AfterStart();
        }

        // run immediately after Start()
        internal protected virtual void AfterStart()
        {
        }

        // stops enqueueing more tasks, but still keeps everything in memory etc
        internal void Pause()
        {
            if (Running && !Paused)
            {
                Paused = true;
            }
            else
            {
                throw new InvalidOperationException("Already paused or not running");
            }
        }

        // resumes queueing
        internal void Resume()
        {
            if (Running && Paused)
            {
                Paused = false;
            }
            else
            {
                throw new InvalidOperationException("Not paused or not running");
            }

        }


        internal void Stop()
        {
            if (Running)
            {
                Running = false;
                AfterStop();
            }
            else
            {
                throw new InvalidOperationException("Not running");
            }
        }

        // Called immediately after Stop()
        protected internal virtual void AfterStop()
        {
        }

        internal void Loop()
        {
            this.Running = true;

            while (this.Running)
            {
                this.LoopAction();
            }

            this.Running = false;
            this.Exited = true;
        }

        // Called in every loop, main module functionality that runs in extra thread goes here
        internal abstract void LoopAction();

        // waits for everything to stop
        internal abstract void WaitForShutdown();
    }
}
