using Newtonsoft.Json;
using RestSharp;
using ShipX.Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    public class Result<T>
    {
        public T Data { get; private set; }
        public Error Error { get; private set; }
        public bool Success { get; private set; }
        public IRestResponse Response { get; private set; }

        public Result(IRestResponse response)
        {
            if (response == null)
            {
                throw new Exception($"Result() Ctor. -> Param: 'response' cannot be null!");
            }

            Response = response;

            handleResponse(response);
        }

        private void handleResponse(IRestResponse response)
        {
            prepareError(response);
            prepareData(response);
        }

        private void prepareError(IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Error = null;
                Success = false;
                try
                {
                    Error = JsonConvert.DeserializeObject<Error>(response.Content);
                }
                catch (Exception e)
                {
                    throw new Exception($"Result->prepareError(): {e.Message}");
                }        
            }
            else
            {
                Error = null;
                Success = true;
            }
        }

        private void prepareData(IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Created || response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Success = true;
                try
                {
                    Data = JsonConvert.DeserializeObject<T>(response.Content);
                }
                catch (Exception e)
                {
                    throw new Exception($"Result->prepareData(): {e.Message}");
                }
            }
            
        }
    }
}
