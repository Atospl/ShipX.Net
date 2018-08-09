using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    public class ResponseBase
    {
        //protected void PrepareError(IRestResponse response)
        //{
        //    if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.NotFound)
        //    {
        //        Error = null;
        //        Success = false;
        //        try
        //        {
        //            Error = JsonConvert.DeserializeObject<Error>(response.Content);
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception($"Result->prepareError(): {e.Message}");
        //        }
        //    }
        //    else
        //    {
        //        Error = null;
        //        Success = true;
        //    }
        //}

        //protected void PrepareData(IRestResponse response)
        //{
        //    if (response.StatusCode == System.Net.HttpStatusCode.Created || response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        Success = true;
        //        try
        //        {
        //            Data = JsonConvert.DeserializeObject<T>(response.Content);
        //        }
        //        catch (Exception e)
        //        {
        //            throw new Exception($"Result->prepareData(): {e.Message}");
        //        }
        //    }

        //}
    }
}
