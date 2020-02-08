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
        public string Get(string op, int a, int b)
        {
            string result = op + " " + a.ToString() + " " + b.ToString();                     
            return result;
        }

        static async Task<string> GetData()
        {
            
            //location of our webhook
            string Url = "http://localhost:5000/Home/About";

            //some content to send into the webhook
            StringContent stringContent = new StringContent(
                "{ \"WEBHOOKDATA\": \"John\" }",
                UnicodeEncoding.UTF8,
                "application/json");

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
