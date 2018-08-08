using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    class LabelResult : IResult
    {
        public bool Success { get; private set; }
        public IRestResponse Response { get; private set; }
        public byte[] RawData { get; private set; }
        
        public LabelResult()
        {

        }

        public LabelResult(IRestResponse response)
        {
            HandleResponse(Response);
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

        }

        private void PrepareError(IRestResponse response)
        {

        }

    }
}
