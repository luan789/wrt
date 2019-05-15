namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_station
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_station()
        {
            wrt_i_route = new HashSet<wrt_i_route>();
            wrt_i_route1 = new HashSet<wrt_i_route>();
            wrt_i_substation = new HashSet<wrt_i_substation>();
        }

        [Key]
        [StringLength(7)]
        public string id_station { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_route> wrt_i_route { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_route> wrt_i_route1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_substation> wrt_i_substation { get; set; }
    }
}
