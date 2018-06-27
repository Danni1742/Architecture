using Moq;
using WebApiCore.Interfaces;
using WebApiCore.Models;
using WebApiCore.Services;
using Xunit;

namespace WebApiCore.Tests
{
    public class MobileServiceTest
    {
        [Fact]
        public void TestPhoneBrand()
        {
            var mock = new Mock<IMobileRepository>();

            mock.Setup(m => m.GetPhoneFromDatabase()).Returns(GetTestPhoneRepository());

            var mobileService = new MobileService(mock.Object);

            var expectedResult = GetTestPhoneExpected().Brand;

            var result = mobileService.GetPhone().Brand;

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void TestPhoneModel()
        {
            var mock = new Mock<IMobileRepository>();

            mock.Setup(m => m.GetPhoneFromDatabase()).Returns(GetTestPhoneRepository());

            var mobileService = new MobileService(mock.Object);

            var expectedResult = GetTestPhoneExpected().Model;

            var result = mobileService.GetPhone().Model;

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void TestPhoneDisplay()
        {
            var mock = new Mock<IMobileRepository>();

            mock.Setup(m => m.GetPhoneFromDatabase()).Returns(GetTestPhoneRepository());

            var mobileService = new MobileService(mock.Object);

            var expectedResult = GetTestPhoneExpected().Display;

            var result = mobileService.GetPhone().Display;

            Assert.Equal(expectedResult, result);

        }

        private MobileModel GetTestPhoneRepository()
        {
            var mobileModel = new MobileModel
            {
                Brand = "Samsung",
                Model = "Galaxy S7",
                Display = 5.5
            };

            return mobileModel;
        }

        private MobileModel GetTestPhoneExpected()
        {
            var mobileModel = new MobileModel
            {
                Brand = "Samsung",
                Model = "Galaxy S7",
                Display = 5.5
            };

            return mobileModel;
        }
    }
}