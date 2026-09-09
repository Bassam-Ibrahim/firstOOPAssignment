using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    #region DeliveryAddress struct
    public struct DeliveryAddress
    {
        public string city;
        public string street;
        public int BuildingNumber;
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            this.city = city;
            this.street = street;
            this.BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{city}, {street}, {BuildingNumber}";

        }
    }
}
#endregion
