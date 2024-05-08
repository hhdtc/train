using Microsoft.AspNetCore.Authentication;

namespace OrderApi.Util
{
    public class URLConstant
    {
        public static string BaseURL = "http://host.docker.internal:8080/";

        public static string PRODUCT_GET_ALL = "api/Product/GetAll";

        public static string PRODUCT_GET_BY_ID = "api/Product/Get/";
    }
}
