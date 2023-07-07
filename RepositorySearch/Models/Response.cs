namespace RepositorySearch.Models
{
    public class Response<T>
    {
        public int StatusCode { get; set; }
        public int ErrorCode { get; set; }
        public string StatusMessage { get; set; }
        public string ErrorMessage { get; set; }
        public bool  isSuccess { get; set; }
        public T Data { get; set; }
    }

    public class ResponseData
    {
        public string responseData { get; set; }
    }
}
