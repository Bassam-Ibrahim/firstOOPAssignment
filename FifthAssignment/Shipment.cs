using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace FifthAssignment
{
    #region Shipment struct
    public struct Shipment
    {
        private string TrackingCode;
        private string Description;
        private double Weight;
        private Decimal DeliveryFee;
        public DeliveryAddress Destination { get; set; }
        public string trackingCode
        {
            get { return TrackingCode; }

        }
        public string description
        {
            get
            {
                return Description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    Description = value;
            }

        }
        public double weight
        {
            get { return Weight; }
            set
            {
                if (value > 0)
                    Weight = value;
            }
        }
        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            set
            {
                if (value >= 0)
                    DeliveryFee = value;
            }
        }
        public decimal EstimatedDeliveryTCost
        {
            get { return DeliveryFee + ((decimal)Weight * 5); }

        }
        public Shipment(string TrackingCode)
        {

            this.TrackingCode = string.IsNullOrWhiteSpace(TrackingCode) ? "Unknown" : TrackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);

        }
        public Shipment(string TrackingCode, string Description, double Weight, decimal DeliveryFee, DeliveryAddress Destination)
        {
            this.TrackingCode = string.IsNullOrWhiteSpace(TrackingCode) ? "Unknown" : TrackingCode;
            this.Description = string.IsNullOrWhiteSpace(Description) ? "Unknown" : Description;
            this.Weight = Weight > 0 ? Weight : 1;
            this.DeliveryFee = DeliveryFee >= 0 ? DeliveryFee : 50;
            this.Destination = Destination;
        }
        public void UpdateDeliveryFee(decimal updatedFee)
        {
            if (updatedFee >= 0)
                DeliveryFee = updatedFee;
        }
        public void printShipmentDetails()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Estimated Total Cost: ${EstimatedDeliveryTCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }

    }
    #endregion
}
