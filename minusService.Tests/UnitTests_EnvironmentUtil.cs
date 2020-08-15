using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using multiservice.Models;
using Microsoft.Extensions.Configuration; 

namespace minusService.Tests
{
    [TestClass]
    public class unitTests_EnvironmentUtil
    {
 
        [TestMethod]
        public void environmentUtilFrameworkVersionIsString()
        {   
            var result = EnvironmentUtils.GetFrameworkDescription();

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void environmentUtilNetCoreVersionIsString()
        {   
            var result = EnvironmentUtils.GetNetCoreVersion();

            Assert.IsInstanceOfType(result, typeof(string));
        }

    }
}
