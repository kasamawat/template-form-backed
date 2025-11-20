using template_form_backed.Application.Users;

namespace template_form_backed.Api.Common
{
    public class ApiResponse<T>
    {
        public T? Data {  get; set; }
        public string Status { get; set; } = "success";
        public string? Message { get; set; }

        public ApiResponse() { }

        public ApiResponse(T? data, string status = "success", string? message = null) 
        {
            Data = data;
            Status = status;
            Message = message;
        }

        public static ApiResponse<T> Success(T data, string? message = null)
        {
            return new(data, "success", message);
        }
        public static ApiResponse<T> Fail(string message)
        {
            return new(default!, "error", message);
        }
    }
}
