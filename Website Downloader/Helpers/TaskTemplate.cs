namespace WebsiteDownloader.Helpers
{
    using System;

    internal abstract class TaskTemplate
    {
        private Action<TaskTemplate> listener;

        private TaskStatus _status;
        internal TaskStatus Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
                if (listener != null)
                {
                    listener.Invoke(this);
                }
            }
        }

        public TaskTemplate(Action<TaskTemplate> listener)
        {
            this.listener = listener;
        }
    }
}
