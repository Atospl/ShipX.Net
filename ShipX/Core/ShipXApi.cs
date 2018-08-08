using Newtonsoft.Json;
using RestSharp;
using ShipX.Net.Core;
using ShipX.Net.Model;
using System.Threading.Tasks;
using System;
using ShipX.Net.Enum;
using System.IO;

namespace ShipX.Net.Core
{
    public class ShipXClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipXClient"/> class.
        /// </summary>
        /// <param name="_organizationId">The _organizationId<see cref="string"/></param>
        /// <param name="bearerToken">The bearerToken<see cref="string"/></param>
        public ShipXClient(string _organizationId, string bearerToken) : base(_organizationId, bearerToken)
        {

        }
        
        public ApiResult<Shipment> CreateShipment(Shipment shipment)
        {
            RestRequest request = createShipmentRequest(shipment);
            IRestResponse response = RestClient.Execute(request);
            return new ApiResult<Shipment>(response);
        }

        public ApiResult<Shipment> GetShipmentInfo(string id)
        {
            RestRequest request = createGetShipmentInfo(id);
            IRestResponse response = RestClient.Execute(request);
            return new ApiResult<Shipment>(response);
        }

        public byte[] DownloadShipmentLabelRaw(string shipmentId, LabelFormatEnum format = LabelFormatEnum.Pdf, LabelTypeEnum type = LabelTypeEnum.normal)
        {
            RestRequest request = createDownloadShipmentLabel(shipmentId, format, type);
            return RestClient.DownloadData(request);
        }

        public void  DownloadShipmentLabelV2(string shipmentId, LabelFormatEnum format = LabelFormatEnum.Pdf, LabelTypeEnum type = LabelTypeEnum.normal)
        {
            RestRequest request = createDownloadShipmentLabel(shipmentId, format, type);

            IRestResponse response = RestClient.Execute(request);



        }
        
        #region async
        public async Task<ApiResult<Shipment>> CreateShipmentAsync(Shipment shipment)
        {
            RestRequest request = createShipmentRequest(shipment);
            IRestResponse response = await RestClient.ExecuteTaskAsync(request);
            return new ApiResult<Shipment>(response);
        }

        public async Task<ApiResult<Shipment>> GetShipmentInfoAsync(string id)
        {
            RestRequest request = createGetShipmentInfo(id);
            IRestResponse response = await RestClient.ExecuteTaskAsync(request);
            return new ApiResult<Shipment>(response);
        }


        public async Task<ApiResult<Shipment>> BuyShipmentAsync(string shipment_id, string offer_id)
        {
            RestRequest request = createBuyShipmentRequest(shipment_id, offer_id);
            IRestResponse response = await RestClient.ExecuteTaskAsync(request);
            return new ApiResult<Shipment>(response);
        }

        public async Task<ApiResult<Shipment>> SelectOfferAsync(string shipment_id, string offer_id)
        {
            RestRequest request = createSelectOfferRequest(shipment_id, offer_id);
            IRestResponse response = await RestClient.ExecuteTaskAsync(request);
            return new ApiResult<Shipment>(response);
        }

        public async Task<ApiResult<LabelData>> DownloadShipmentLabelAsync(string shipmentId, LabelFormatEnum format = LabelFormatEnum.Pdf, LabelTypeEnum type = LabelTypeEnum.normal)
        {
            RestRequest request = createDownloadShipmentLabel(shipmentId, format, type);

            IRestResponse response = await RestClient.ExecuteTaskAsync(request);

            byte[] response2 = RestClient.DownloadData(request);

            File.WriteAllBytes(@"C:\\test.pdf", response2);

            return new ApiResult<LabelData>(response);
        }
        #endregion
        
    }
}
