namespace aspnet_api_swagger_design
{
    /// <summary>
    /// Api Response Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponse<T>
    {
        public T Result { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public static ApiResponse<T> Fail(string errorMessage)
        {
            return new ApiResponse<T> { Succeeded = false, Message = errorMessage };
        }
        public static ApiResponse<T> Success(T result)
        {
            return new ApiResponse<T> { Succeeded = true, Result = result };
        }
    }
}
