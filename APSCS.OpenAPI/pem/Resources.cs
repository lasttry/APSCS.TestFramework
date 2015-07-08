using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.OpenAPI.pem
{
    public struct act_params
    {
        public string var_name { get; set; }
        public string var_value { get; set; }
    }

    public struct addResourceTypeRequest
    {
        public string resclass_name { get; set; }
        public string name { get; set; }
        public string descr { get; set; }
        public string[] attrs { get; set; }
        public act_params[] act_params { get; set; }
    }

    public struct addResourceTypeResult
    {
        public int resource_type_id { get; set; }
    }

    [XmlRpcUrl("http://127.0.0.1:8440/RPC2")]
    public interface Resources : IXmlRpcProxy
    {
        [XmlRpcMethod("pem.addResourceType")]
        POAResponse addResourceType(addResourceTypeRequest request);
    }
}
