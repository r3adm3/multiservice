using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using multiservice.Models;
using Microsoft.Extensions.Configuration; 

namespace minusService.Tests
{
    [TestClass]
    public class unitTests_sharedMath
    {
        [TestMethod]
        public void sharedMathMinusTwoNumbers()
        {

            var sharedMath = new sharedMath();

            var result = sharedMath.minusTwoNumbers(5,2);

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

            Assert.AreEqual(result, ".NET Core   2.2.8");
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