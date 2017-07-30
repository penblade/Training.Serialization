using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Serialization.Models;

namespace Training.Serialization.Tests
{
    [TestClass]
    public class SerializeAndDeserializePrimaryAddress
    {
        private PrimaryAddress OriginalAddress { get; set; }
        private PrimaryAddress DeserializedAddress { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            // Arrange
            OriginalAddress = new PrimaryAddress()
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
            var serialized = DataContractSerializerUtility.Serialize(OriginalAddress);
            DeserializedAddress = DataContractSerializerUtility.Deserialize<PrimaryAddress>(serialized);
        }

        [TestMethod]
        public void ThenOriginalIsNotNull()
        {
            Assert.IsNotNull(OriginalAddress);
        }

        [TestMethod]
        public void ThenDeserializedIsNotNull()
        {
            Assert.IsNotNull(DeserializedAddress);
        }

        [TestMethod]
        public void ThenOriginalAndDeserializedAreNotSame()
        {
            Assert.AreNotSame(OriginalAddress, DeserializedAddress);
        }

        [TestMethod]
        public void ThenFullNameAreEqual()
        {
            Assert.AreEqual(OriginalAddress.FullName, DeserializedAddress.FullName);
        }

        [TestMethod]
        public void ThenAddress1AreEqual()
        {
            Assert.AreEqual(OriginalAddress.AddressLine1, DeserializedAddress.AddressLine1);
        }

        [TestMethod]
        public void ThenAddress2AreEqual()
        {
            Assert.AreEqual(OriginalAddress.AddressLine2, DeserializedAddress.AddressLine2);
        }

        [TestMethod]
        public void ThenCityAreEqual()
        {
            Assert.AreEqual(OriginalAddress.City, DeserializedAddress.City);
        }

        [TestMethod]
        public void ThenStateOrProvinceOrRegionAreEqual()
        {
            Assert.AreEqual(OriginalAddress.StateOrProvinceOrRegion, DeserializedAddress.StateOrProvinceOrRegion);
        }

        [TestMethod]
        public void ThenCountryAreEqual()
        {
            Assert.AreEqual(OriginalAddress.Country, DeserializedAddress.Country);
        }

        [TestMethod]
        public void ThenZipOrPostalCodeAreEqual()
        {
            Assert.AreEqual(OriginalAddress.ZipOrPostalCode, DeserializedAddress.ZipOrPostalCode);
        }
    }
}
