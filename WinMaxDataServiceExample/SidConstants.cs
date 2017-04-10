
using System.Runtime.Serialization;

namespace WinMaxDataServiceExample
{
    /// <summary>
    /// SID number constants.
    /// </summary>
    public static class SidConstants
    {
      public enum SID
      {
        SID_RT_LAMP_FEED_HOLD,
        SID_RT_TOOL_IN_SPINDLE,
        SID_WINMAX_RUNNING_LOCAL_FEED,
        SID_RT_SPINDLE_OVERRIDE_POT,
        SID_RT_FEED_OVERRIDE_POT,
        SID_RT_RAPID_OVERRIDE_POT,
        SID_RT_SPINDLE_SPEED,
        SID_RT_PROGRAM_RUNNING,
        SID_RT_PART_COUNT,
        SID_RT_SERVO_POWER,
        SID_RT_EMERGENCY_STOP,
        SID_WINMAX_MACHINE_MODE_CHANGED,
        SID_WINMAX_NC_POUND_VARIABLE_NUMBER,
        SID_WINMAX_RUN_PROGRAM_NAME,
        SID_WINMAX_RUN_PROGRAM_BLOCK_NUMBER,
        SID_UI_BULK_MACHINE_POSITION,
        SID_UI_BULK_LAST_NOTIFICATION,
        SID_WCF_BULK_TOOL_DATA,
        SID_UI_BULK_CURRENT_PART_SETUP,
        SID_CURRENT_PROGRAM_STATUS,
        SID_RT_WAITING_ON_REMOTE_PROGRAM_START
      }
    }
  [DataContract]
  public class MachinePosition
  {
    [DataMember]
    public double[] dMachinePosition;
  }
}
