using System.Threading.Tasks;
using MaidCentralInterview.Models.TokenAuth;
using MaidCentralInterview.Web.Controllers;
using Shouldly;
using Xunit;

namespace MaidCentralInterview.Web.Tests.Controllers
{
    public class HomeController_Tests: MaidCentralInterviewWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}