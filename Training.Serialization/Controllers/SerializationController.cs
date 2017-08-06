using Microsoft.AspNetCore.Mvc;
using Training.Serialization.Models;

namespace Training.Serialization.Controllers
{
    [Route("api/[controller]")]
    public class SerializationController : Controller
    {
        [HttpGet]
        [Route("PrimaryAddress")]
        public PrimaryAddress Get()
        {
            // Arrange
            var address = new PrimaryAddress()
            {
                FullName = $"Test {nameof(PrimaryAddress.FullName)}",
                AddressLine1 = $"Test {nameof(PrimaryAddress.AddressLine1)}",
                AddressLine2 = $"Test {nameof(PrimaryAddress.AddressLine2)}",
                City = $"Test {nameof(PrimaryAddress.City)}",
                StateOrProvinceOrRegion = $"Test {nameof(PrimaryAddress.StateOrProvinceOrRegion)}",
                Country = $"Test {nameof(PrimaryAddress.Country)}",
                ZipOrPostalCode = $"Test {nameof(PrimaryAddress.ZipOrPostalCode)}"
            };

            return address;
        }

        [HttpPost]
        [Route("PrimaryAddress")]
        public void Post([FromBody]PrimaryAddress address)
        {
        }
    }
}
