using MaidCentralInterview.Debugging;

namespace MaidCentralInterview
{
    public class MaidCentralInterviewConsts
    {
        public const string LocalizationSourceName = "MaidCentralInterview";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1ba4c478609347d98102ea3354edafb2";
    }
}
