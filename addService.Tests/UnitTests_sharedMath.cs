using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using multiservice.Models;
using Microsoft.Extensions.Configuration; 

namespace addService.Tests
{
    [TestClass]
    public class unitTests_sharedMath
    {
        [TestMethod]
        public void sharedMathAddTwoNumbers()
        {

            var sharedMath = new sharedMath();

            var result = sharedMath.addTwoNumbers(1,2);

            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void sharedMathdotnetverIsString()
        {
            var sharedMath = new sharedMath();

            var result = sharedMath.dotnetver;

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void sharedMathdotnetverThreeZeroOne()
        {
            var sharedMath = new sharedMath();

            var result = sharedMath.dotnetver;

            Assert.AreEqual(result, ".NET Core   3.0.1");
        }

        [TestMethod]
        public void sharedMathhostnameIsString()
        {
            var sharedMath = new sharedMath();

            var result = sharedMath.hostname;

            Assert.IsInstanceOfType(result, typeof(string));
        }

    }
}
