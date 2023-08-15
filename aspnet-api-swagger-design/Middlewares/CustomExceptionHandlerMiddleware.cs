using aspnet_api_swagger_design.CustomExceptions;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace aspnet_api_swagger_design.Middlewares
{
    /// <summary>
    /// ExceptionHandlerMiddleware
    /// </summary>
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="next"></param>
        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = ApiResponse<string>.Fail(exception.Message);
                switch (exception)
                {
                    case ProductNotCreatedException
                         or ArgumentNullException:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        
                        break;
                    case KeyNotFoundException:
                        // not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel = ApiResponse<string>.Fail(string.Join(Environment.NewLine, exception.Message, exception.StackTrace));
                        break;
                }

                Logger.LogError(exception.Message, exception);

                var result = JsonSerializer.Serialize(responseModel);
                await response.WriteAsync(result);
            }
        }
    }
}
