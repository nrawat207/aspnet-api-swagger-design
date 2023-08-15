using System.Diagnostics.Eventing.Reader;

namespace aspnet_api_swagger_design
{
    /// <summary>
    /// Logger
    /// </summary>
    public class Logger
    {
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void LogInfo(string message)
        {
            //Log the info
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void LogError(string message, Exception exception)
        {
            //Log error
        }
    }
}
