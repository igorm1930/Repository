using RepositorySearch.Models;

namespace RepositorySearch.BL
{
    public class SearchRepositoryBL
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SearchRepositoryBL()
        {
           
        }
        public SearchRepositoryBL(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        //public async Task<Response<ResponseData>> Search(string searchKeyword)
        //{
        //    HttpResponseMessage httpResponseMessage;
        //    Task<Response<ResponseData>> response = new Task<Response<ResponseData>>() {  Result = new Response<ResponseData>() { } };
        //    string responseData = string.Empty;
        //    try
        //    {
        //        var configuration = new ConfigurationBuilder().AddXmlFile("Web.config").Build();
        //        var url = configuration["appSettings:GitHub_URL"];

        //        if (!string.IsNullOrEmpty(searchKeyword))
        //        {
        //            var httpClient = _httpClientFactory.CreateClient();

        //            var apiUrl = url + $"?q={searchKeyword}";

        //            httpResponseMessage = await httpClient.GetAsync(apiUrl);
        //            if (httpResponseMessage.IsSuccessStatusCode)
        //            {
        //                responseData = await httpResponseMessage.Content.ReadAsStringAsync();
        //                response.Result.Data.responseData = responseData;
        //                response.Result.isSuccess = true;
        //                response.Result.StatusCode = 0;
        //                response.Result.StatusMessage = "Search Succeded!";
        //            }
        //            else
        //            {
        //                response.Result.isSuccess = false;
        //                response.Result.StatusCode = -1;
        //                response.Result.StatusMessage = "Search Failed!";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Result.Data.responseData = null;
        //        response.Result.isSuccess = false;
        //        response.Result.StatusCode = -99;
        //        response.Result.StatusMessage = "Search Failed!";
        //        response.Result.ErrorMessage = "Search exception:" + ex.Message;
        //    }

        //    return response;
        //}
    }
}
