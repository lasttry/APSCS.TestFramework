using APSCS.OpenAPI.pem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSCS.OpenAPI
{
    public class XmlRPC
    {
        public string Server { get; set; }

        public XmlRPC(string server)
        {
            Server = server;
        }

        public getAccountInfoResponse getAccountInfo(int account_id)
        {
            pem.Account account = CookComputing.XmlRpc.XmlRpcProxyGen.Create<pem.Account>();

            account.Url = Server;

            var response = account.getAccountInfo(new getAccountInfoRequest(1)).result;

            return Utility.Cast<getAccountInfoResponse>(response);
        }

        public importPackageResponse importPackage(string package_url, bool disable_package = false)
        {
            pem.APS aps = CookComputing.XmlRpc.XmlRpcProxyGen.Create<pem.APS>();

            aps.Url = Server;

            var response = aps.importPackage(new importPackageRequest()
            {
                package_url = package_url,
                disable_package = disable_package
            });
            if (response.status != 0)
            {
                throw new Exception(response.error_message);
            }
            return Utility.Cast<importPackageResponse>(response.result);
        }

        public provideApplicationInstanceResponse provideApplicationInstance(int subscription_id, int rt_id, int app_id, string url_path, settings[] settings, string[] attrs)
        {
            pem.APS aps = CookComputing.XmlRpc.XmlRpcProxyGen.Create<pem.APS>();

            aps.Url = Server;
            var response = aps.provideApplicationInstance(new provideApplicationInstanceRequest()
            {
               subscription_id = subscription_id,
               rt_id = rt_id,
               app_id = app_id,
               url_path = url_path,
               settings = settings,
               attrs = attrs
            });

            return Utility.Cast<provideApplicationInstanceResponse>(response.result);
        }

        public getAccountTokenResponse getAccountToken(int account_id, int subscription_id)
        {
            pem.APS aps = CookComputing.XmlRpc.XmlRpcProxyGen.Create<pem.APS>();

            aps.Url = Server;

            var response = aps.getAccountToken(new getAccountTokenRequest()
            {
                account_id = account_id,
                subscription_id = subscription_id
            });
            return Utility.Cast<getAccountTokenResponse>(response.result);
        }

        public addResourceTypeResult addResourceType(string resclass_name, string name, string descr, List<string> attrs, act_params[] act_params)
        {
            pem.Resources resources = CookComputing.XmlRpc.XmlRpcProxyGen.Create<pem.Resources>();
            resources.Url = Server;

            var response = resources.addResourceType(new addResourceTypeRequest()
            {
                resclass_name = resclass_name,
                name = name,
                descr = descr,
                attrs = attrs.ToArray(),
                act_params = act_params
            });
            return Utility.Cast<addResourceTypeResult>(response.result);
        }
    }
}
