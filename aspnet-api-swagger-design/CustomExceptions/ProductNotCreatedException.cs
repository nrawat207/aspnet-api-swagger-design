using System.Globalization;

namespace aspnet_api_swagger_design.CustomExceptions
{
    /// <summary>
    /// ProductNotCreatedException
    /// </summary>
    public class ProductNotCreatedException : Exception
    {

        /// <summary>
        /// Parameterless Ctor
        /// </summary>
        public ProductNotCreatedException() : base()
        {
        }

        /// <summary>
        /// Ctor with message only
        /// </summary>
        /// <param name="message"></param>
        public ProductNotCreatedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor with message and arguments
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public ProductNotCreatedException(string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
