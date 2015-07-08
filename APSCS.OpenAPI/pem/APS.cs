using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.OpenAPI.pem
{
    public struct importPackageRequest
    {
        public string package_url { get; set; }
        public bool disable_package { get; set; }
    }

    public struct importPackageResponse
    {
        public int application_id { get; set; }
        public string package_version { get; set; }
    }

    public struct provideApplicationInstanceResponse
    {
        public int application_instance_id { get; set; }
        public string application_resource_id { get; set; }
    }

    public struct provideApplicationInstanceRequest
    {
        public int subscription_id { get; set; }
        public int rt_id { get; set; }
        public int app_id { get; set; }
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string package_version { get; set; }
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string domain_name { get; set; }
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string url_path { get; set; }
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public settings[] settings { get; set; }
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string[] attrs { get; set; }
    }

    public struct getAccountTokenRequest
    {
        public int account_id { get; set; }
        public int subscription_id { get; set; }
    }

    public struct getAccountTokenResponse
    {
        public string controller_uri { get; set; }
        public string aps_token { get; set; }
    }

    public struct settings
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    [XmlRpcUrl("http://127.0.0.1:8440/RPC2")]
    public interface APS : IXmlRpcProxy
    {
        [XmlRpcMethod("pem.APS.importPackage")]
        POAResponse importPackage(importPackageRequest request);

        [XmlRpcMethod("pem.APS.provideApplicationInstance")]
        POAResponse provideApplicationInstance(provideApplicationInstanceRequest request);

        [XmlRpcMethod("pem.APS.getAccountToken")]
        POAResponse getAccountToken(getAccountTokenRequest request);
    }
}
