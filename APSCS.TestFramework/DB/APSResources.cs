namespace APSCS.TestFramework.DB
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APSResources
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int apsPackage_Id { get; set; }

        [StringLength(100)]
        public string type { get; set; }

    }
}
