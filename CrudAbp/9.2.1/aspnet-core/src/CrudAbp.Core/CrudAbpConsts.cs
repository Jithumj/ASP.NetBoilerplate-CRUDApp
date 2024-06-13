using CrudAbp.Debugging;

namespace CrudAbp
{
    public class CrudAbpConsts
    {
        public const string LocalizationSourceName = "CrudAbp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ca47f0cbb8ec4fcf8afe53d4e653938c";
    }
}
