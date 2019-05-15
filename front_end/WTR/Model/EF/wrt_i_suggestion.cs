namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_suggestion
    {
        [Key]
        [StringLength(7)]
        public string id_passenger { get; set; }

        public DateTime? date_time { get; set; }

        [StringLength(200)]
        public string content { get; set; }

        public virtual wrt_i_passenger wrt_i_passenger { get; set; }
    }
}
