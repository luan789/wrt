namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_substation
    {
        [Key]
        [StringLength(7)]
        public string id_substation { get; set; }

        [StringLength(50)]
        public string add { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [StringLength(7)]
        public string id_station { get; set; }

        public virtual wrt_i_station wrt_i_station { get; set; }
    }
}
