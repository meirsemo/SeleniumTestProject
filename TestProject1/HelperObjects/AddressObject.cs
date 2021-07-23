
namespace TestProject1.HelperObjects
{
    public class AddressObject
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }

        public static AddressObject TestModel => new AddressObject
        {
            City = "Tel-aviv",
            County = "Israel",
            Street = "Alenbi",
            PostCode = "12345",
        };
    }
}
