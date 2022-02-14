using System;
using System.Net;
using Microsoft.Extensions.Configuration; 

namespace multiservice.Models
{

    public class sharedMath
    {

        public int addTwoNumbers (int a, int b)
        {
            return a+b;
        }

        public int multiplyTwoNumbers(int a, int b)
        {
            return a*b;
        }

        public int minusTwoNumbers(int a, int b)
        {
            return a-b;
        }

        public int mathresult {get;set;}
        public string dotnetver {get
            {
                return EnvironmentUtils.GetFrameworkDescription();
            }
        }
        public string hostname {get
            {
                return Environment.MachineName;
            }
        }
        public string myversion {get
            {
                return "infossato-dev";
            }
        }
    }


}