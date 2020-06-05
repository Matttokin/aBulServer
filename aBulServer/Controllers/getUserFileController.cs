using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aBulServer.Controllers
{
    public class getUserFileController : ApiController
    {
        
        public string Get(string user)
        {
            List<string> text = new List<string>();
            using (StreamReader fs = new StreamReader(cfg.Path2users + user + ".txt"))
            {
                while (true)
                {
                    string temp = fs.ReadLine();

                    if (temp == null) break;

                    text.Add(temp);
                }
            }
            return JsonConvert.SerializeObject(text);
        }

    }
}
