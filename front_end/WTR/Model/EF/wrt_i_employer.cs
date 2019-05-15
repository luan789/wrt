namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_employer
    {
        [Key]
        [StringLength(7)]
        public string id_employer { get; set; }

        [StringLength(7)]
        public string id_group_per { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(15)]
        public string phone { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        [StringLength(50)]
        public string add { get; set; }

        [StringLength(50)]
        public string pass { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        public virtual wrt_i_group_per wrt_i_group_per { get; set; }
    }
}
