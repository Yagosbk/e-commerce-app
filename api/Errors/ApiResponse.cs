using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode{ get; set; }
        public string Message{ get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad request",
                401 => "Not authorized",
                404 => "Resource was not found",
                500 => "Unexpected condition was met",
                _ => null
            };
        }
        
    }
}