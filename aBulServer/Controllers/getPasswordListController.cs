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
    public class getPasswordListController : ApiController
    {
        public string Get()
        {
            List<string> text = new List<string>();
            using (StreamReader fs = new StreamReader(cfg.PasswordListFile))
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
