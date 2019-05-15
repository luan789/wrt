namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_t_schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_t_schedule()
        {
            wrt_i_ticket = new HashSet<wrt_i_ticket>();
        }

        [Key]
        [StringLength(7)]
        public string id_schedule { get; set; }

        [Required]
        [StringLength(7)]
        public string id_route { get; set; }

        [Required]
        [StringLength(7)]
        public string id_driver { get; set; }

        public DateTime? departure { get; set; }

        public double? price { get; set; }

        [StringLength(50)]
        public string note { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [StringLength(15)]
        public string id_bus { get; set; }

        public virtual wrt_i_bus wrt_i_bus { get; set; }

        public virtual wrt_i_driver wrt_i_driver { get; set; }

        public virtual wrt_i_route wrt_i_route { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_ticket> wrt_i_ticket { get; set; }
    }
}
