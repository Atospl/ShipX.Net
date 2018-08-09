using Newtonsoft.Json;
using RestSharp;
using ShipX.Net.Model;
using ShipX.Net.Model.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    public class DownloadResult<T> : IResult<T>
    {
        public bool Success { get; private set; }
        
        public T Data { get; private set; }
        public Error Error { get; private set; }
        public IRestResponse Response { get; private set; }
        
        public DownloadResult() {}
        
        public DownloadResult(IRestResponse response)
        {
            HandleResponse(response);
        }

        public void HandleResponse(IRestResponse response)
        {
            if (response == null)
            {
                throw new Exception($"LabelResult.HandleResponse() => Param: 'response' cannot be null!");
            }

            Response = response;

            PrepareFile(Response);
            PrepareError(Response);

        }

        private void PrepareFile(IRestResponse response)
        {
            if (response.StatusCode == System.Net.HttpStatusCode.Created || response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Success = true;
                try
                {
                    //V1
                    //bad version
                    //T sticker = (T)Activator.CreateInstance(typeof(T));
                    //sticker.GetType().GetProperty("Data").SetValue(typeof(string), content);
                    //sticker.GetType().GetProperty("RawData").SetValue(typeof(byte[]), System.Text.Encoding.UTF8.GetBytes(content));
                    //V2
                    //bad version
                    //to rethink
                    //Sticker sticker = Activator.CreateInstance(typeof(T)) as Sticker;
                    //sticker.Data = content;
                    //sticker.RawData = System.Text.Encoding.UTF8.GetBytes(content);

                    //v3
                    //bad
                    //string json = String.Empty;
                    //foreach (PropertyInfo p in typeof(T).GetProperties())
                    //{
                    //    if (p.MemberType == MemberTypes.Property && !p.PropertyType.IsArray)
                    //    {
                    //        json = $"'{p.Name}': '{response.Content}'";
                    //    }
                    //}


                    //Environment

                    Data = JsonConvert.DeserializeObject<T>(response.Content);



                    

                    //var a = JsonConvert.SerializeObject(response.Content);

                    //JsonConvert.DeserializeObject("", typeof(T), jss);
                    //JsonConvert jc = new JsonConvert();








                    //Data = JsonConvert.DeserializeObject<T>($"'FileData' : '{response.Content}'");
                    




                }
                catch (Exception e)
                {
                    throw new Exception($"Result->prepareData(): {e.Message}");
                }
            }
        }

        private void PrepareError(IRestResponse response)
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

    }
}
