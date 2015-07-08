using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.APSController
{


    public class Controller
    {

        public string APSController { get; set; }
        public string APSToken { get; set; }
        public APSApi APSAPI { get; set; }

        public Resources Resources { get; set; }

        public Controller(string apsController, string apsToken)
        {
            APSController = apsController;
            APSToken = APSToken;

            Resources = new Resources(this);
            APSAPI = new APSApi(apsController, apsToken);
        }
    }
}
