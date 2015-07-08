using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.APSController
{
    public class APSApi
    {
        public string APSController { get; set; }
        public string APSToken { get; set; }

        public APSApi(string apsController, string apsToken)
        {
            APSController = apsController;
            APSToken = apsToken;
        }

        public object SendRequest(string path, Method method, object jsonRequest)
        {
            RestClient client = new RestClient(APSController);
            

            RestRequest request = new RestRequest(path, method);

            //let's ignore the certificate error from the APSC
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            request.AddHeader("APS-Token", APSToken);

            request.AddJsonBody(jsonRequest);

            var result = client.Execute(request);

            dynamic jsonResponse = Newtonsoft.Json.Linq.JObject.Parse(result.Content);

            if(result.StatusCode.GetHashCode() >= 300)
                throw new Exception(result.ErrorMessage);
            if (result.StatusCode == HttpStatusCode.OK)
                return jsonResponse;

            return null;
        }
    }
}
