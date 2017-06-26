using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Serialization.Models;

namespace Training.Serialization.Tests
{
    [TestClass]
    public class DataContractSerializerTests
    {
        [TestMethod]
        public void SerializeAndDeserializeThenSuccess()
        {
            // Arrange
            var originalAddress = new PrimaryAddress()
            {
                FullName = $"Test {nameof(PrimaryAddress.FullName)}",
                AddressLine1 = $"Test {nameof(PrimaryAddress.AddressLine1)}",
                AddressLine2 = $"Test {nameof(PrimaryAddress.AddressLine2)}",
                City = $"Test {nameof(PrimaryAddress.City)}",
                StateOrProvinceOrRegion = $"Test {nameof(PrimaryAddress.StateOrProvinceOrRegion)}",
                Country = $"Test {nameof(PrimaryAddress.Country)}",
                ZipOrPostalCode = $"Test {nameof(PrimaryAddress.ZipOrPostalCode)}"
            };

            // Act
            var serialized = DataContractSerializerUtility.Serialize(originalAddress);
            var deserializedAddress = DataContractSerializerUtility.Deserialize<PrimaryAddress>(serialized);

            // Assert
            Assert.IsNotNull(originalAddress);
            Assert.IsNotNull(deserializedAddress);
            Assert.AreNotSame(originalAddress, deserializedAddress);
            Assert.AreEqual(originalAddress.FullName, deserializedAddress.FullName);
            Assert.AreEqual(originalAddress.AddressLine1, deserializedAddress.AddressLine1);
            Assert.AreEqual(originalAddress.AddressLine2, deserializedAddress.AddressLine2);
            Assert.AreEqual(originalAddress.City, deserializedAddress.City);
            Assert.AreEqual(originalAddress.StateOrProvinceOrRegion, deserializedAddress.StateOrProvinceOrRegion);
            Assert.AreEqual(originalAddress.Country, deserializedAddress.Country);
            Assert.AreEqual(originalAddress.ZipOrPostalCode, deserializedAddress.ZipOrPostalCode);
        }
    }
}
