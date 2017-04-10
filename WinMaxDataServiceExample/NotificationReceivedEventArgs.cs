using System;

namespace WinMaxDataServiceExample
{
    /// <summary>
    /// Event arguments for the NotificationReceived event.
    /// </summary>
    public class NotificationReceivedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the NotificationReceivedEventArgs class.
        /// </summary>
        /// <param name="sid">The SID number.</param>
        /// <param name="value">The SID's value.</param>
        public NotificationReceivedEventArgs(string sid, string value)
        {
            Sid = (SidConstants.SID)Enum.Parse(typeof(SidConstants.SID), sid);
            Value = value;
        }

        /// <summary>
        /// The SID number.
        /// </summary>
        public SidConstants.SID Sid { get; private set; }

        /// <summary>
        /// The SID's value.
        /// </summary>
        public string Value { get; private set; }
    }
}
