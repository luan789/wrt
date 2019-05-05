namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_per
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_per()
        {
            wrt_i_group_per = new HashSet<wrt_i_group_per>();
        }

        [Key]
        [StringLength(7)]
        public string id_per { get; set; }

        [StringLength(7)]
        public string name { get; set; }

        [StringLength(2)]
        public string content_per { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_group_per> wrt_i_group_per { get; set; }
    }
}
