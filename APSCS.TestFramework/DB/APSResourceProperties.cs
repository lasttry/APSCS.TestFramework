namespace APSCS.TestFramework.DB
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APSResourceProperties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int resource_id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string value { get; set; }

    }
}
