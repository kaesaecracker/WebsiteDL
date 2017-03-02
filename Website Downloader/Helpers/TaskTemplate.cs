namespace WebsiteDownloader.Helpers
{
    using System;

    internal abstract class TaskTemplate
    {
        // the status change listener
        private Action<TaskTemplate> listener;

        // internal field used for Status property
        private TaskStatus _status;

        public TaskTemplate(Action<TaskTemplate> listener)
        {
            this.listener = listener;
        }

        // Fire event listener when value changes
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
