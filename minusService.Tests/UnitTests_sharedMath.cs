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
        public void sharedMathdotnetverFiveZero()
        {
            var sharedMath = new sharedMath();

            var result = sharedMath.dotnetver;

            // only grab the semver major and minor version, not build ver too)
            result = result.Substring(0,result.LastIndexOf("."));

            Assert.AreEqual(".NET   6.0", result);
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
