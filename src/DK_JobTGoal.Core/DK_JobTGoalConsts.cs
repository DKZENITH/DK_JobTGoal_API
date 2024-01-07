using DK_JobTGoal.Debugging;

namespace DK_JobTGoal
{
    public class DK_JobTGoalConsts
    {
        public const string LocalizationSourceName = "DK_JobTGoal";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4e486a7bdcb244ab98c59bffb5071f48";
    }
}
