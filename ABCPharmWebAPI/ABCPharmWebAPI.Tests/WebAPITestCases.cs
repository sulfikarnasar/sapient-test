using ABCPharmWebAPI.DAL;
using ABCPharmWebAPI.Models;
using ABCPharmWebAPI.Services;
using Moq;
using System;
using Xunit;

namespace ABCPharmWebAPI.Tests
{
    public class WebAPITestCases
    {
        private readonly Mock<IABCPharmRepository> abcPharmRepoMock;
        public WebAPITestCases()
        {
            abcPharmRepoMock = new Mock<IABCPharmRepository>();
            Medicine medicine = new Medicine
            {
                Id = 1,
                Brand = "ABCBrand",
                Expiry = DateTime.Now.ToString("MM/dd/yyyy"),
                Name="VitamCTablet",
                Price=5,
                Quantity=87
            };
            abcPharmRepoMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(medicine);
        }
        [Fact]
        public void GetDetailedInfoById_Test()
        {
            IABCPharmServices service = new ABCPharmaService(abcPharmRepoMock.Object);
            var item=service.GetDetailedInfoById(1);
            Assert.NotNull(item);
        }
    }
}
