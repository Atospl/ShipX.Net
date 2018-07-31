using System;
using System.Threading.Tasks;
using RestSharp.Serializers;
using ShipX.Net.Core;
using Newtonsoft.Json;

namespace ShipX.Net.Model
{
    /// <summary>
    /// Defines the <see cref="Shipment" />
    /// </summary>
    public class Shipment
    {
        public string id { get; set; }

        /// <summary>
        /// <para></para>Miejsce powstania kosztów<para>
        /// <para>Atrybut nie jest wymagany.</para>
        /// <para>Maksymalnie 255 znaków.</para>
        /// <para>Jeśli atrybut jest podany, weryfikujemy czy przynależy do organizacji, z której wykonywane jest żądanie.</para>
        /// <para>możliwość przekazania pustego atrybutu.</para>
        /// </summary>
        public string mpk { get; set; }

        /// <summary>
        /// <para>Dowolny komentarz.</para>
        /// <para>Atrybut nie jest wymagany.</para>
        /// <para>Maksymalnie 255 znaków</para>
        /// <para>Jeśli atrybut jest podany, weryfikujemy czy przynależy do organizacji, z której wykonywane jest żądanie.</para>
        /// <para>Maksymalnie 255 znaków</para>
        /// </summary>
        public string comments { get; set; }

        /// <summary>
        /// Gets or sets the external_customer_id
        /// </summary>
        public string external_customer_id { get; set; }

        /// <summary>
        /// 
        /// <para>Atrybut jest wymagany.</para>
        /// <para>Jeśli ma być przedstawiona oferta usługi kurierskiej, należy podać co najmniej receiver.company_name i/lub receiver.first_name i receiver.last_name oraz obiekt address.</para>
        /// <para>Jeśli ma być przedstawiona oferta paczkomatowa należy podać receiver.phone_number i receiver.email.</para>
        /// <para>Podanie wszystkich danych umożliwi przedstawienie ofert obu typów.</para>
        /// <para>Jeśli zostanie przekazany atrybut is_return == true, atrybut receiver nie będzie wymagany.</para>
        /// 
        /// </summary>
        public Receiver receiver { get; set; }

        /// <summary>
        /// Gets or sets the parcels
        /// </summary>
        public Parcel[] parcels { get; set; }

        /// <summary>
        /// <para>Dane paczek zawartych w przesyłce.</para>
        /// <para>Atrybut nie jest wymagany.</para>
        /// <para>Dane paczek zawartych w przesyłce.</para>
        /// <para>Wymagane jest podanie paczkomatu w przypadku przesyłki paczkomatowej.</para>
        /// </summary>
        public CustomAttributes custom_attributes { get; set; }

        /// <summary>
        /// Gets or sets the insurance
        /// </summary>
        public Insurance insurance { get; set; }

        /// <summary>
        /// Gets or sets the cod
        /// </summary>
        public Cod cod { get; set; }

        /// <summary>
        /// <param>Atrybut jest wymagany.</param>
        /// <para>ServiceEnum</para>
        /// </summary>
        public string service { get; set; }

        /// <summary>
        /// Gets or sets the additional_services
        /// </summary>
        public string[] additional_services { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
