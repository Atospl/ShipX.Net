using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Core
{
    public interface IResult
    {
        
       bool Success { get; }
       IRestResponse Response { get;}
       void HandleResponse(IRestResponse response);


    }
}
