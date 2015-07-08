namespace APSCS.TestFramework.DB
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APSPackages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string apsPackage { get; set; }

        [StringLength(100)]
        public string endpoint { get; set; }

        public bool deployEndpoint { get; set; }
    }
}
