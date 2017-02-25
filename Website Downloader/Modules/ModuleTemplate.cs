namespace WebsiteDownloader.Modules
{
    using System;
    using System.Threading;

    internal abstract class ModuleTemplate
    {
        private Thread runThread = null;

        protected internal bool Paused { get; protected set; } = false;

        protected internal bool Running { get; protected set; } = false;

        protected internal bool Exited { get; protected set; } = false;

        internal void Start()
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
        }

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
                this.LoopAction();
            }

            this.Shutdown();
            this.Running = false;
            this.Exited = true;
        }

        internal abstract void LoopAction();

        internal abstract void Shutdown();
    }
}
