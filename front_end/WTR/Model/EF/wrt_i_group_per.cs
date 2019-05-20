namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_group_per
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_group_per()
        {
            wrt_i_employer = new HashSet<wrt_i_employer>();
        }

        [Key]
        [StringLength(7)]
        public string id_group_per { get; set; }

        [StringLength(7)]
        public string id_per { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_employer> wrt_i_employer { get; set; }

        public virtual wrt_i_per wrt_i_per { get; set; }
    }
}
