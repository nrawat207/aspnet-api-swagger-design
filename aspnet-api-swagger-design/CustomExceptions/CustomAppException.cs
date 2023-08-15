using System.Globalization;

namespace aspnet_api_swagger_design.CustomExceptions
{

    /// <summary>
    /// CustomAppException
    /// </summary>
    public class CustomAppException : Exception
    {

        /// <summary>
        /// Parameterless Ctor
        /// </summary>
        public CustomAppException() : base()
        {
        }

        /// <summary>
        /// Ctor with message only
        /// </summary>
        /// <param name="message"></param>
        public CustomAppException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor with message and arguments
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public CustomAppException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
