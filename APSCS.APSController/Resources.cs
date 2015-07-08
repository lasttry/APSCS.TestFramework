using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.APSController
{
    public class Resources
    {
        public Controller Controller { get; set; }

        public Resources(Controller controller)
        {
            Controller = controller;
        }

        public void CreateResource(object resource)
        {
            Controller.APSAPI.SendRequest("/aps/2/resources/", RestSharp.Method.POST,resource);
                //Newtonsoft.Json.JsonConvert.SerializeObject(resource,
                //Newtonsoft.Json.Formatting.None,
                //new Newtonsoft.Json.JsonSerializerSettings { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore }));
        }
    }
}
