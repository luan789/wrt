namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_ticket
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string id_ticket { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string id_schedule { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(7)]
        public string id_passenger { get; set; }

        [StringLength(5)]
        public string number_seat { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        public virtual wrt_i_passenger wrt_i_passenger { get; set; }

        public virtual wrt_t_schedule wrt_t_schedule { get; set; }
    }
}
