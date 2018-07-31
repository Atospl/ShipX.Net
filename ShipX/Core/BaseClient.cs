using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShipX.Net.Model;
using Newtonsoft.Json;
using ShipX.Net.Enum;

namespace ShipX.Net.Core
{
    public class BaseClient
    {
        public string BASE_URL{ get { return "https://api-shipx-pl.easypack24.net"; } }
        public static string API_VERSION { get { return "1.9.3";} }
        
        public string BearerToken { get; protected set; }
        public string OrganizationId { get; protected set; }
        public RestClient RestClient { get; protected set; }

        private RestSharp.Serializers.JsonSerializer JsonSerializer = new RestSharp.Serializers.JsonSerializer();

        internal BaseClient(string organizationId, string bearerToken)
        {
            if (string.IsNullOrEmpty(bearerToken))
            {
                throw new Exception("Bearer token cannot be null or empty!");
            }

            if (string.IsNullOrEmpty(organizationId))
            {
                throw new Exception("Organization Id cannot be null or empty!");
            }

            OrganizationId = organizationId;
            BearerToken = bearerToken;
            
            RestClient = new RestClient();
            RestClient.BaseUrl = new Uri(BASE_URL);
            RestClient.AddDefaultParameter("Authorization", string.Format("Bearer " + BearerToken), ParameterType.HttpHeader);

        }
        
        protected RestRequest createShipmentRequest(Shipment shipment)
        {
            RestRequest request = new RestRequest($"/v1/organizations/{OrganizationId}/shipments", Method.POST);
            request.AddParameter("application/json", shipment.ToJson(), ParameterType.RequestBody);
            return request;
        }

        protected RestRequest createBuyShipmentRequest(string id)
        {
            RestRequest request = new RestRequest($"/v1/shipments/{id}/buy", Method.POST);
            request.AddParameter("application/json", "{ \"offer_id\": \"VAR\" }".Replace("VAR", id), ParameterType.RequestBody);
            return request;
        }

        protected RestRequest createDownloadShipmentLabel(string id, LabelFormatEnum format, LabelTypeEnum type)
        {
            RestRequest request = new RestRequest($"/v1/shipments/{id}/label?format={format.ToString()}&type={type.ToString()}", Method.GET);
            return request;
        }
    }
}
