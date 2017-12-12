using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleCode.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string info = "Connected to Database:";
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString =
                        "Data Source=gavin.c2dcjnlfgwhg.ap-southeast-2.rds.amazonaws.com;" +
                        "Initial Catalog=master;" +
                        "User id=master;" +
                        "Password=admin123;";
                conn.Open();
                // Create the command
                info += conn.Database;
            }
            return new string[] { "Hello CenITex", info };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
