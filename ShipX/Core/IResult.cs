using RestSharp;
using ShipX.Net.Model.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    public interface IResult<T>
    {
        bool Success { get; }
        
        T Data { get; }
        Error Error { get; }
        IRestResponse Response { get; }
        
        void HandleResponse(IRestResponse response);
       
    }
}
