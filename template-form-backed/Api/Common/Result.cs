namespace template_form_backed.Api.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string? Error { get; set; }
        public T? Value { get; set; }

        private Result(bool isSuccess, T? value, string? error)
        {
            IsSuccess = isSuccess;
            Error = error;
            Value = value;
        }

        public static Result<T> Success(T value)
            => new(true, value, null);

        public static Result<T> Failure(string error)
            => new(false, default, error);
    }
}
