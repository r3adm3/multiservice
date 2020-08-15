using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using frontEnd.Controllers;
using Microsoft.Extensions.Configuration; 

namespace frontEnd.Tests
{
    [TestClass]
    public class unitTests_homeController
    {
        
        IConfiguration _configuration;

        [TestMethod]
        public void HomeControllerCanInstantiate()
        {
            var controller = new HomeController(_configuration);

            var result = controller.About();

            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void MathControllerCanInstantiate()
        {
            var controller = new MathController(_configuration);

            Assert.IsNotNull(controller);

        }


    }
}
