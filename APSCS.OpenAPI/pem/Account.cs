using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;
using System.Reflection;

namespace APSCS.OpenAPI.pem
{

    public static class Utility
    {
        public static T Cast<T>(this object input, Type t = null)
        {
            if (input == null)
                return default(T);

            Type target = typeof(T);

            if (target == typeof(object) && t != null)
                target = t;

            var result = Activator.CreateInstance(target, false);

            XmlRpcStruct st = (XmlRpcStruct)input;

            var d = from source in target.GetMembers().ToList()
                    where source.MemberType == MemberTypes.Property
                    select source;

            PropertyInfo propertyInfo;
            foreach (MemberInfo memberInfo in d.ToList())
            {
                if (st.ContainsKey(memberInfo.Name))
                {

                    propertyInfo = target.GetProperty(memberInfo.Name);
                    object val = st[memberInfo.Name];
                    if (st[memberInfo.Name].GetType() == typeof(XmlRpcStruct))
                    {
                        //if ( == typeof(Person))
                        val = Cast<object>(val, propertyInfo.PropertyType);
                    }

                    propertyInfo.SetValue(result, val, null);
                }
            }

            return (T)result;
        }
    }

    public struct Person
    {
        public string title { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string company_name { get; set; }
    }
    public struct Address
    {
        public string street_name { get; set; }
        public string house_num { get; set; }
        public string address2 { get; set; }
        public string zipcode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }
    public struct Phone
    {
        public string country_code { get; set; }
        public string area_code { get; set; }
        public string phone_num { get; set; }
        public string ext_num { get; set; }
    }
    public struct Fax
    {
        public string country_code { get; set; }
        public string area_code { get; set; }
        public string phone_num { get; set; }
        public string ext_num { get; set; }
    }

    public struct getAccountInfoResponse
    {
        public string account_type { get; set; }
        public int parent_account_id { get; set; }
        public Person person { get; set; }
        public Address address { get; set; }
        public Phone phone { get; set; }
        public Fax fax { get; set; }
        public string email { get; set; }
        public string note { get; set; }
    }

    public struct POAResponse
    {
        public int status;
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public object result;
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string module_id;
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public int extype_id;
        [XmlRpcMissingMapping(MappingAction.Ignore)]
        public string error_message;
    }
    public struct getAccountInfoRequest
    {
        public getAccountInfoRequest(int account_id)
        {
            this.account_id = account_id;
        }

        public int account_id;
    }

    [XmlRpcUrl("http://127.0.0.1:8440/RPC2")]
    public interface Account : IXmlRpcProxy
    {
        [XmlRpcMethod("pem.getAccountInfo")]
        POAResponse getAccountInfo(getAccountInfoRequest request);
    }
}
