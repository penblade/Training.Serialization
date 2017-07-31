using System.Diagnostics;
using System.Runtime.Serialization;

namespace Training.Serialization.Models
{
    public class PrimaryAddress
    {
        public PrimaryAddress()
        {
            Debug.WriteLine($"{nameof(PrimaryAddress)} - Constructor");
        }

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            Debug.WriteLine($"{nameof(PrimaryAddress)} - {nameof(OnSerializing)}");
        }

        [OnSerialized]
        private void OnSerialized(StreamingContext context)
        {
            Debug.WriteLine($"{nameof(PrimaryAddress)} - {nameof(OnSerialized)}");
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            Debug.WriteLine($"{nameof(PrimaryAddress)} - {nameof(OnDeserializing)}");
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Debug.WriteLine($"{nameof(PrimaryAddress)} - {nameof(OnDeserialized)}");
        }

        public string FullName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateOrProvinceOrRegion { get; set; }
        public string ZipOrPostalCode { get; set; }
        public string Country { get; set; }
    }
}
