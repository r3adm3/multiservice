using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Configuration; 
using System.Net.Http;
using System.Text;

namespace frontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {

        IConfiguration _configuration;
       
        public MathController(IConfiguration configuration)
        {
            _configuration = configuration;
        } 

        // GET api/values
        [HttpGet]
        public string Get(string op, string a, string b)
        {
            string resultFromGetData = GetData(op, a.ToString(), b.ToString()).Result;                    
            return resultFromGetData;
        }

        static async Task<string> GetData(string op, string a, string b)
        {
            string kubePod= "";

            switch (op)
            {
                case "add":
                    kubePod = "myservice-as";
                    break;
                case "minus":
                    kubePod = "myservice-mis";
                    break;
                case "multiply":
                    kubePod = "myservice-mxs";
                    break;
                default:
                    break;


            }
            //location of our webhook
            string Url = "http://" + kubePod + "/api/" + op + "?a=" + a + "&b=" + b;

            string data;

            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                
                //Setting up the response...         
                using (HttpResponseMessage res = await client.GetAsync(Url))
                {        
                    using (HttpContent content = res.Content)
                    {
                        data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            Console.WriteLine(data);
                        }
                    }
            
                }
            }

            return data;



        }        

    }
}
