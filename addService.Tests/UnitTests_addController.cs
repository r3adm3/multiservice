using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using addService.Controllers;
using Microsoft.Extensions.Configuration; 

namespace addService.Tests
{
    [TestClass]
    public class unitTests_addController
    {
        [TestMethod]
        public void addControllerTwoPlusOneEqualsThree()
        {
            var controller = new addController();

            var result = controller.Get(2,1);

            var actualResult = result.Value;

            Assert.AreEqual(3, actualResult.mathresult);

        }

    }
}
