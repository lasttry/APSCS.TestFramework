namespace APSCS.TestFramework.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class APSCSModel : DbContext
    {
        public static string SELECT_OSASettings = "SELECT * FROM OSASettings";
        public static string DELETE_OSASettings = "DELETE FROM OSASettings WHERE id = ?";
        public static string INSERT_OSASettings = "INSERT INTO OSASettings (name, poa_hostname, poa_password, endpoint_hostname, endpoint_password) VALUES (?, ?, ?, ?, ?)";
        public static string UPDATE_OSASettings = "UPDATE OSASettings SET name = ?, poa_hostname = ?, poa_password = ?, endpoint_hostname = ?, endpoint_password = ? WHERE id = ?";

        public static string SELECT_APSPackages = "SELECT * FROM APSPackages";
        public static string DELETE_APSPackages = "DELETE FROM APSPackages WHERE id = ?";
        public static string INSERT_APSPackages = "INSERT INTO APSPackages (name, apsPackage, endpoint, deployEndpoint) VALUES (?, ?, ?, ?)";
        public static string UPDATE_APSPackages = "UPDATE APSPackages SET name = ?, apsPackage = ?, endpoint = ?, deployEndpoint = ? WHERE id = ?";

        public static string SELECT_APSSettings = "SELECT * FROM APSSettings WHERE apsPackage_id = ?";
        public static string DELETE_APSSettings = "DELETE FROM APSSettings WHERE id = ?";
        public static string INSERT_APSSettings = "INSERT INTO APSSettings (name, value, apsPackage_id) VALUES (?, ?, ?)";
        public static string UPDATE_APSSettings = "UPDATE APSSettings SET name = ?, value = ? WHERE id = ?";

        public static string SELECT_APSResources = "SELECT * FROM APSResources WHERE apsPackage_id = ?";
        public static string DELETE_APSResources = "DELETE FROM APSResources WHERE id = ?";
        public static string INSERT_APSResources = "INSERT INTO APSResources (type, apsPackage_id) VALUES(?, ?)";
        public static string UPDATE_APSResources = "UPDATE APSResources SET type = ? WHERE id = ?";

        public static string SELECT_APSResourceProperties = "SELECT * FROM APSResourceProperties WHERE resource_id = ?";
        public static string DELETE_APSResourceProperties = "DELETE FROM APSResourceProperties WHERE id = ?";
        public static string DELETE_APSResourcePropertiesByResourceId = "DELETE FROM APSResourceProperties WHERE resource_id = ?";
        public static string INSERT_APSResourceProperties = "INSERT INTO APSResourceProperties (name, value, resource_id) VALUES (?, ?, ?)";
        public static string UPDATE_APSResourceProperties = "UPDATE APSResourceProperties SET name = ?, value = ? WHERE id = ?";

        public APSCSModel()
            : base("name=APSCSModel")
        {
        }

        public virtual DbSet<OSASettings> OSASettings { get; set; }
        public virtual DbSet<APSPackages> APSPackages { get; set; }
        public virtual DbSet<APSSettings> APSSettings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
