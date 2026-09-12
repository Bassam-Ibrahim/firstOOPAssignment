
using FifthAssignment;

class Program
{
    public static void Main(String[] args)
    {
        #region first question
        /*
         a) DeliveryAddress is a struct so it is a value type  so when we copy it creates an indpendent copy  modifing the copy does not affect the original struct.
         b) DeliveryAddress is a class so it is a reference type so when we copy it creates a reference to the same object modifing the copy affects the original class.
         */
        #endregion
        #region Second question
        /*
         a) 
             1. Fields Are Public so  modifing it Dirctly
             2. No Validations on Data so we can set any value to it
             3. NO Encapsulation so we can access it from anywhere
         b) 
            private fields hide the internal data 
            so the properties provide ways to access and modifing this field and Manage the conditions of the data and also we can add validation to the data before setting it to the field.
          */
        #endregion

        #region Last question At assignment 
     
       
            DeliveryCenter center = new DeliveryCenter();

        
            Console.WriteLine("Enter Shipment 1 Data");

            string code, desc, city, street;
            double weight;
            decimal fee;
            int building;

            do
            {
                Console.Write("Tracking Code: ");
                code = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(code));

            
            do
            {
                Console.Write("Description: ");
                desc = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(desc));

            while (true)
            {
                Console.Write("Weight: ");
                if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                    break;
            }

            while (true)
            {
                Console.Write("Delivery Fee: ");
                if (decimal.TryParse(Console.ReadLine(), out fee) && fee > 0)
                    break;
            }

            do
            {
                Console.Write("City: ");
                city = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(city));

            do
            {
                Console.Write("Street: ");
                street = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(street));

            while (true)
            {
                Console.Write("Building Number: ");
                if (int.TryParse(Console.ReadLine(), out building) && building > 0)
                    break;
            }

            DeliveryAddress address = new DeliveryAddress(city, street, building);

            Shipment shipment = new Shipment(code, desc, weight, fee, address);

            if (center.AddShipment(shipment))
                Console.WriteLine("Shipment added successfully.");
            else
                Console.WriteLine("Delivery center is full.");

           
            Console.WriteLine("--- All Shipments ---");

            center[0].printShipmentDetails();

            Console.Write("Enter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = center[searchCode];

            if (!string.IsNullOrEmpty(found.trackingCode))
            {
                Console.WriteLine($"Shipment found: {found.trackingCode} - {found.description}");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

            Console.WriteLine("--- Struct Copy Test ---");

            DeliveryAddress original = new DeliveryAddress("Cairo", "Tahrir Street", 15);

            DeliveryAddress copy = original;

            copy.BuildingNumber = 20;
            copy.street = "Shoubra Misr Street";

            Console.WriteLine($"Original Address: {original.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {copy.GetFullAddress()}");
        }
    }
        #endregion





