namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_route()
        {
            wrt_t_schedule = new HashSet<wrt_t_schedule>();
        }

        [Key]
        [StringLength(7)]
        public string id_route { get; set; }

        [Required]
        [StringLength(7)]
        public string id_origin { get; set; }

        [Required]
        [StringLength(7)]
        public string id_destinate { get; set; }

        public TimeSpan? estimate_time { get; set; }

        [StringLength(50)]
        public string note { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        public virtual wrt_i_station wrt_i_station { get; set; }

        public virtual wrt_i_station wrt_i_station1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_t_schedule> wrt_t_schedule { get; set; }
    }
}
