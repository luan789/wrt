namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wrt_i_passenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wrt_i_passenger()
        {
            wrt_i_ticket = new HashSet<wrt_i_ticket>();
        }

        [Key]
        [StringLength(7)]
        public string id_passenger { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        [StringLength(50)]
        public string pass { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        public virtual wrt_i_suggestion wrt_i_suggestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wrt_i_ticket> wrt_i_ticket { get; set; }
    }
}
