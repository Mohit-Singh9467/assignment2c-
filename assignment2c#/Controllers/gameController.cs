using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2c_.Controllers
{

    [RoutePrefix("api/game")]
    public class gameController : ApiController
    {
        [HttpGet]
        [Route("DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        count++;
                    }
                }
            }

            string wayWord = count == 1 ? "way" : "ways";
            return $"There are {count} {wayWord} to get the sum 10.";
        }
    }
}
