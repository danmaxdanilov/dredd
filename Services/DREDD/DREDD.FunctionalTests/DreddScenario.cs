using DREDD.FunctionalTests.Base;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DREDD.FunctionalTests
{
    public class DreddScenario : DreddScenarioBase
    {
        [Fact]
        public async Task Get_basket_and_response_ok_status_code()
        {
            using (var server = CreateServer())
            {
                var response = await server.CreateClient()
                   .GetAsync(Get.GetTestNumber());

                response.EnsureSuccessStatusCode();
            }
        }
    }
}
