using System;
using System.Collections.Generic;
using System.Text;

namespace FifthAssignment
{
    #region DeliveryCenter struct
    public struct DeliveryCenter
    {
        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].trackingCode == trackingCode)
                        return shipments[i];
                }

                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrEmpty(shipments[i].trackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
    }
    #endregion
}
