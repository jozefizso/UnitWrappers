using System.ComponentModel;

namespace UnitWrappers.System.ComponentModel
{
    public interface IBackgroundWorker : IComponent
    {
        [Browsable(false)]
        bool CancellationPending { get; }

        [Browsable(false)]
        bool IsBusy { get; }

        [DefaultValue(false)]
        bool WorkerReportsProgress { get; set; }

        [DefaultValue(false)]
        bool WorkerSupportsCancellation { get; set; }

        event DoWorkEventHandler DoWork;
        event ProgressChangedEventHandler ProgressChanged;
        event RunWorkerCompletedEventHandler RunWorkerCompleted;
        void CancelAsync();
        void ReportProgress(int percentProgress);
        void ReportProgress(int percentProgress, object userState);
        void RunWorkerAsync();
        void RunWorkerAsync(object argument);
    }
}