
namespace WinMaxDataServiceExample
{
    /// <summary>
    /// Job list file load statuses.
    /// </summary>
    public enum JobListFileLoadStatus
    {
        Inactive = 0,
        Loading = 1,
        WaitingForFile = 2,
        LoadSuccess = 3,
        LoadError = 4,
        LoadAborted = 5
    }
}
