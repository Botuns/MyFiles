using System.Collections.Generic;

namespace BotunsEngApi.DTOs
{
    public class BaseResponseModel <T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        
    }
    public class BaseResponseModels <T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public IList<T> Data { get; set; }
    }
}
