using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace UnitWrappers.System.ComponentModel
{
    public class BackgroundWorkerWrap : IBackgroundWorker
    {
        internal BackgroundWorker UnderlyingObject { get; set; }

        public BackgroundWorkerWrap()
        {
            UnderlyingObject = new BackgroundWorker();
        }

        public BackgroundWorkerWrap(BackgroundWorker backgroundWorker)
        {
            UnderlyingObject = backgroundWorker;
        }

        [Browsable(false)]
        public
        bool CancellationPending
        {
            get { return UnderlyingObject.CancellationPending; }
        }

        [Browsable(false)]
        public bool IsBusy
        {
            get
            {
                return UnderlyingObject.IsBusy;
            }
        }

        [DefaultValue(false)]
        public bool WorkerReportsProgress
        {
            get
            {
                return UnderlyingObject.WorkerReportsProgress;
            }
            set
            {
                UnderlyingObject.WorkerReportsProgress = value;
            }
        }


        [DefaultValue(false)]
        public bool WorkerSupportsCancellation
        {
            get
            {
                return UnderlyingObject.WorkerSupportsCancellation;
            }
            set
            {
                UnderlyingObject.WorkerSupportsCancellation = value;
            }
        }


        public event DoWorkEventHandler DoWork
        {
            add
            {
                UnderlyingObject.DoWork+=value;
            }
            remove
            {
                UnderlyingObject.DoWork -= value;
            }
        }

        public event ProgressChangedEventHandler ProgressChanged
        {
            add
            {
                UnderlyingObject.ProgressChanged += value;
            }
            remove
            {
                UnderlyingObject.ProgressChanged -= value;
            }
        }

        public event RunWorkerCompletedEventHandler RunWorkerCompleted
        {
            add
            {
                UnderlyingObject.RunWorkerCompleted += value;
            }
            remove
            {
                UnderlyingObject.RunWorkerCompleted -= value;
            }
        }

        public void CancelAsync()
        {
            UnderlyingObject.CancelAsync();
        }

        public void ReportProgress(int percentProgress)
        {
            UnderlyingObject.ReportProgress(percentProgress);
        }

        public void ReportProgress(int percentProgress, object userState)
        {
            UnderlyingObject.ReportProgress(percentProgress, userState);
        }

        public void RunWorkerAsync()
        {
            UnderlyingObject.RunWorkerAsync();
        }

        public void RunWorkerAsync(object argument)
        {
            UnderlyingObject.RunWorkerAsync(argument);
        }

#if !ANDROID

        public void Dispose()
        {
            UnderlyingObject.Dispose();
        }

        public ISite Site
        {
            get { return UnderlyingObject.Site; }
            set {  UnderlyingObject.Site = value; }
        }

        public event EventHandler Disposed
        {
            add { UnderlyingObject.Disposed += value; }
            remove { UnderlyingObject.Disposed -= value; }
        }
#endif
    }
}
