namespace WebsiteDownloader.Helpers
{
    using System;

    internal abstract class TaskTemplate
    {
        private Action<TaskTemplate> listener;

        private TaskStatus _status;

        public TaskTemplate(Action<TaskTemplate> listener)
        {
            this.listener = listener;
        }

        internal TaskStatus Status
        {
            get
            {
                return this._status;
            }

            set
            {
                this._status = value;
                if (this.listener != null)
                {
                    (new System.Threading.Thread(() => this.listener.Invoke(this))).Start();
                }
            }
        }


    }
}
