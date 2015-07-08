using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace APSCS.TestFramework.DB
{
    public class Database
    {
        private string connectionString;
        private SQLiteConnection connection;

        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["APSCS.TestFramework.Properties.Settings.APSCS_TestFrameworkConnectionString"].ConnectionString;
            connection = new SQLiteConnection(connectionString);
        }

        #region internal

        internal DataTable Get(string query, params SQLiteParameter[] parameters)
        {
            DataTable dt;

            if (connection.State != ConnectionState.Open)
                connection.Open();
            try
            {
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = query;
                foreach (SQLiteParameter parameter in parameters)
                    command.Parameters.Add(parameter);

                dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(dt);

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        internal void Execute(SQLiteCommand command)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region APSPackages

        public DataTable ASPPackages_Get()
        {
            return Get(APSCSModel.SELECT_APSPackages);
        }

        public void APSPackages_Save(string id, string name, string apsPackage, string endpoint, bool deployEndpoint)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("apsPackage", apsPackage);
            command.Parameters.AddWithValue("endpoint", endpoint);
            command.Parameters.AddWithValue("deployEndpoint", deployEndpoint);

            if (id.Length == 0)
                command.CommandText = APSCSModel.INSERT_APSPackages;
            else
            {
                command.CommandText = APSCSModel.UPDATE_APSPackages;
                command.Parameters.AddWithValue("id", id);
            }

            Execute(command);
        }

        public void APSPackages_Delete(string id)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("id", id);
            command.CommandText = APSCSModel.DELETE_APSPackages;

            Execute(command);
        }

        #endregion

        #region OSASettings

        public DataTable OSASettings_Get()
        {
            return Get(APSCSModel.SELECT_OSASettings);
        }

        public void OSASettings_Save(string id, string name, string poahostname, string poapassword, string endpointhostname, string endpointpassword)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("poa_hostname", poahostname);
            command.Parameters.AddWithValue("poa_password", poapassword);
            command.Parameters.AddWithValue("endpoint_hostname", endpointhostname);
            command.Parameters.AddWithValue("endpoint_password", endpointpassword);

            if (id.Length == 0)
                command.CommandText = APSCSModel.INSERT_OSASettings;
            else
            {
                command.CommandText = APSCSModel.UPDATE_OSASettings;
                command.Parameters.AddWithValue("id", id);
            }

            Execute(command);
        }

        public void OSASettings_Delete(string id)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("id", id);
            command.CommandText = APSCSModel.DELETE_OSASettings;

            Execute(command);
        }

        #endregion

        #region APSSettings

        public DataTable APSSettings_Get(string apsPackage_id)
        {
            return Get(APSCSModel.SELECT_APSSettings, new SQLiteParameter("id", apsPackage_id));
        }

        public void APSSettings_Save(string id, string apsPackage_id, string name, string value)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("value", value);

            if (id.Length == 0)
            {
                command.CommandText = APSCSModel.INSERT_APSSettings;
                command.Parameters.AddWithValue("apsPackage_id", apsPackage_id);
            }
            else
            {
                command.CommandText = APSCSModel.UPDATE_APSSettings;
                command.Parameters.AddWithValue("id", id);
            }

            Execute(command);
        }

        public void APSSettings_Delete(string id)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("id", id);
            command.CommandText = APSCSModel.DELETE_APSSettings;

            Execute(command);
        }

        #endregion

        #region APSResources

        public DataTable APSResources_Get(string apsPackage_id)
        {
            return Get(APSCSModel.SELECT_APSResources, new SQLiteParameter("id", apsPackage_id));
        }

        public void APSResources_Save(string id, string apsPackage_id, string type)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("type", type);

            if (id.Length == 0)
            {
                command.CommandText = APSCSModel.INSERT_APSResources;
                command.Parameters.AddWithValue("apsPackage_id", apsPackage_id);
            }
            else
            {
                command.CommandText = APSCSModel.UPDATE_APSResources;
                command.Parameters.AddWithValue("id", id);
            }

            Execute(command);
        }

        public void APSResources_Delete(string id)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("id", id);
            command.CommandText = APSCSModel.DELETE_APSResources;

            Execute(command);
        }

        #endregion

        #region APSResourceProperties

        public DataTable APSResourceProperties_Get(string resource_id)
        {
            return Get(APSCSModel.SELECT_APSResourceProperties, new SQLiteParameter("id", resource_id));
        }

        public void APSResourceProperties_Save(string id, string resource_id, string name, string value)
        {
            SQLiteCommand command = connection.CreateCommand();

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("value", value);

            if (id.Length == 0)
            {
                command.CommandText = APSCSModel.INSERT_APSResourceProperties;
                command.Parameters.AddWithValue("resource_id", resource_id);
            }
            else
            {
                command.CommandText = APSCSModel.UPDATE_APSResourceProperties;
                command.Parameters.AddWithValue("id", id);
            }

            Execute(command);
        }

        public void APSResourceProperties_Delete(string id, string resource_id = null)
        {
            SQLiteCommand command = connection.CreateCommand();

            if (string.IsNullOrEmpty(resource_id))
            {
                command.Parameters.AddWithValue("id", id);
                command.CommandText = APSCSModel.DELETE_APSResourceProperties;
            }
            else
            {
                command.Parameters.AddWithValue("resource_id", resource_id);
                command.CommandText = APSCSModel.DELETE_APSResourcePropertiesByResourceId;
            }

            Execute(command);
        }

        #endregion
    }
}
