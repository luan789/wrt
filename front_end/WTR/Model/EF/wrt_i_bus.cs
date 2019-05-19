namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_bus()
        {
            wrt_t_schedule = new HashSet<wrt_t_schedule>();
        }

        [Key]
        [StringLength(15)]
        public string id_bus { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(50)]
        public string note { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_t_schedule> wrt_t_schedule { get; set; }
    }
}
