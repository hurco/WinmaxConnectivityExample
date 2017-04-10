using WinMaxDataServiceExample.NotificationService;

namespace WinMaxDataServiceExample
{
    /// <summary>
    /// Notification Service callback implementation class.
    /// </summary>
    public class NotificationServiceCallback : INotificationServiceCallback
    {
        public event NotificationReceivedEventHandler NotificationReceived;

        #region INotificationServiceCallback Implementation

        /// <summary>
        /// Called by the Notification Service when a SID notification is sent.
        /// </summary>
        /// <param name="sid">The SID number.</param>
        /// <param name="value">The SID's value.</param>
        public void Notify(string sid, string value)
        {
            if (NotificationReceived != null)
            {
                NotificationReceived(this, new NotificationReceivedEventArgs(sid, value));
            }
        }

        #endregion
    }
}
