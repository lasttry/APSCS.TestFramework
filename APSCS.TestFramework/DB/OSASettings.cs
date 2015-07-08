namespace APSCS.TestFramework.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OSASettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string poa_hosname { get; set; }

        [Required]
        [StringLength(100)]
        public string poa_password { get; set; }

        [StringLength(100)]
        public string endpoint_hostname { get; set; }

        [StringLength(100)]
        public string endpoint_password { get; set; }
    }
}
