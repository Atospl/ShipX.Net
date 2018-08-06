using System;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShipX.Net.Core;
using ShipX.Net.Enum;
using ShipX.Net.Model;

namespace ShipX.Test
{
    [TestClass]
    public class InpostLockerAllegroTypeTest
    {
        [TestMethod]
        public void GetValidShipXClient_ShouldNotNull()
        {
            ShipXClient client = Helper.GetShipXClient();
            Assert.IsNotNull(Helper.GetShipXClient());
        }
        
        [TestMethod]
        public void InpostLocker_ForceError_Case__ReciverEmailMissing()
        {
            ShipXClient client = Helper.GetShipXClient();

            var tstReciver = new Faker<Receiver>("pl");
            tstReciver.RuleFor(r => r.email, f => "")
                .RuleFor(r => r.phone, f => f.Phone.PhoneNumber("#########"));

            var tstCustomAtrr = new Faker<CustomAttributes>("pl")
                .RuleFor(r => r.sending_method, SendingMethodEnum.dispatch_order.ToString())
                .RuleFor(r => r.target_point, "WOL04A");
                

            var tstShipment = new Faker<Shipment>("pl")
                .RuleFor(r => r.reference, f => f.Random.Hash(10))
                .RuleFor(f => f.service, ServiceEnum.inpost_locker_allegro.ToString())
                .RuleFor(f => f.receiver, tstReciver)
                .RuleFor(f => f.custom_attributes, tstCustomAtrr);
            


            Result<Shipment> result = client.CreateShipment(tstShipment);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Error);
            Assert.AreNotEqual(0, result.Error.details.receiver[0].email.Count);
            

        }

        [TestMethod]
        public void InpostLocker_ForceError_Case__ReciverPhoneMissing()
        {
            ShipXClient client = Helper.GetShipXClient();

            var tstReciver = new Faker<Receiver>("pl");
            tstReciver.RuleFor(r => r.email, f => f.Internet.Email())
                .RuleFor(r => r.phone, "");

            var tstCustomAtrr = new Faker<CustomAttributes>("pl")
                .RuleFor(r => r.sending_method, SendingMethodEnum.dispatch_order.ToString())
                .RuleFor(r => r.target_point, "WOL04A");


            var tstShipment = new Faker<Shipment>("pl")
                .RuleFor(r => r.reference, f => f.Random.Hash(10))
                .RuleFor(f => f.service, ServiceEnum.inpost_locker_allegro.ToString())
                .RuleFor(f => f.receiver, tstReciver)
                .RuleFor(f => f.custom_attributes, tstCustomAtrr);

            Result<Shipment> result = client.CreateShipment(tstShipment);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Error);
            Assert.AreNotEqual(0, result.Error.details.receiver[0].phone.Count);


        }





    }
}
