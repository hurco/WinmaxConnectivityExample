using System.ComponentModel;

namespace WinMaxDataServiceExample
{
    /// <summary>
    /// Represents the status of the machine.
    /// </summary>
    public class MachineStatus : INotifyPropertyChanged
    {
        private bool feedHold;
        private bool joblistActive;
        private JobListFileLoadStatus currentJobListFileLoadStatus;
        private bool joblistProgramCompleted;
        private bool jobListProgramRunSequenceInitiated;
        private bool jobListRunPending;
        private bool jobListAutoRunMode;
        private string jobListRunningFileLoadName = "N/A";
        private string jobListRunningJobName = "N/A";
        private string jobListRunningJobListName = "N/A";
        private int toolInSpindle;

        /// <summary>
        /// Indicates the status of the feed hold.
        /// </summary>
        public bool FeedHold
        {
            get { return feedHold; }
            set
            {
                if (feedHold == value) return;
                feedHold = value;
                OnPropertyChanged("FeedHold");
            }
        }

        /// <summary>
        /// Indicates a job list is active, either loading files for a job or running a job.
        /// </summary>
        public bool JobListActive
        {
            get { return joblistActive; }
            set
            {
                if (joblistActive == value) return;
                joblistActive = value;
                OnPropertyChanged("JobListActive");
            }
        }

        /// <summary>
        /// The current job list file load status.
        ///   Inactive - Files are not being loaded for a job.
        ///   Loading - Files are being loaded for the next job.
        ///   WaitingForFile - Waiting for a specific file that cannot be found.
        ///   LoadSuccess - All files loaded successfully for a job.
        ///   LoadError - An error prevented a file from loading.
        ///   LoadAborted - File loading process aborted by user.
        /// </summary>
        public JobListFileLoadStatus CurrentJobListFileLoadStatus
        {
            get { return currentJobListFileLoadStatus; }
            set
            {
                if (currentJobListFileLoadStatus == value) return;
                currentJobListFileLoadStatus = value;
                OnPropertyChanged("CurrentJobListFileLoadStatus");
            }
        }

        /// <summary>
        /// Indicates successful completion of a single job.
        /// </summary>
        public bool JobListProgramCompleted
        {
            get { return joblistProgramCompleted; }
            set
            {
                if (joblistProgramCompleted == value) return;
                joblistProgramCompleted = value;
                OnPropertyChanged("JobListProgramCompleted");
            }
        }

        /// <summary>
        /// Indicates start cycle has been pressed for first job in job list.
        /// </summary>
        public bool JobListProgramRunSequenceInitiated
        {
            get { return jobListProgramRunSequenceInitiated; }
            set
            {
                if (jobListProgramRunSequenceInitiated == value) return;
                jobListProgramRunSequenceInitiated = value;
                OnPropertyChanged("JobListProgramRunSequenceInitiated");
            }
        }
        
        /// <summary>
        /// Indicates a program is loaded, queued for interpretation and ready for simulated start cycle.
        /// </summary>
        public bool JobListRunPending
        {
            get { return jobListRunPending; }
            set
            {
                if (jobListRunPending == value) return;
                jobListRunPending = value;
                OnPropertyChanged("JobListRunPending");
            }
        }

        /// <summary>
        /// Indicates whethern the running job list automatically initiates the execution of all jobs after the first one 
        /// without requiring additional Start Cycle presses for each job. 
        /// </summary>
        public bool JobListAutoRunMode
        {
            get { return jobListAutoRunMode; }
            set
            {
                if (jobListAutoRunMode == value) return;
                jobListAutoRunMode = value;
                OnPropertyChanged("JobListAutoRunMode");
            }
        }

        /// <summary>
        /// The name of the file that is loading during the job loading step.
        /// </summary>
        public string JobListRunningFileLoadName
        {
            get { return jobListRunningFileLoadName; }
            set
            {
                if (jobListRunningFileLoadName == value) return;
                jobListRunningFileLoadName = value;
                OnPropertyChanged("JobListRunningFileLoadName");
            }
        }

        /// <summary>
        /// The name of the job that is currently running.
        /// </summary>
        public string JobListRunningJobName
        {
            get { return jobListRunningJobName; }
            set
            {
                if (jobListRunningJobName == value) return;
                jobListRunningJobName = value;
                OnPropertyChanged("JobListRunningJobName");
            }
        }

        /// <summary>
        /// The name of the job list that is currently running.
        /// </summary>
        public string JobListRunningJobListName
        {
            get { return jobListRunningJobListName; }
            set
            {
                if (jobListRunningJobListName == value) return;
                jobListRunningJobListName = value;
                OnPropertyChanged("JobListRunningJobListName");
            }
        }

        /// <summary>
        /// Indicates the index of the tool in the spindle.
        /// </summary>
        public int ToolInSpindle
        {
            get { return toolInSpindle; }
            set
            {
                if (toolInSpindle == value) return;
                toolInSpindle = value;
                OnPropertyChanged("ToolInSpindle");
            }
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        /// <param name="property">The property that changed.</param>
        protected void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(property));
            }
        }

        #endregion
    }
}
