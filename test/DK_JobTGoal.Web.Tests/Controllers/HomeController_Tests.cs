using System.Threading.Tasks;
using DK_JobTGoal.Models.TokenAuth;
using DK_JobTGoal.Web.Controllers;
using Shouldly;
using Xunit;

namespace DK_JobTGoal.Web.Tests.Controllers
{
    public class HomeController_Tests: DK_JobTGoalWebTestBase
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