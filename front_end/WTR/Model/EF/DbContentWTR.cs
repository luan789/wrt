namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContentWTR : DbContext
    {
        public DbContentWTR()
            : base("name=DbContentWTR")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<wrt_i_bus> wrt_i_bus { get; set; }
        public virtual DbSet<wrt_i_driver> wrt_i_driver { get; set; }
        public virtual DbSet<wrt_i_employer> wrt_i_employer { get; set; }
        public virtual DbSet<wrt_i_group_per> wrt_i_group_per { get; set; }
        public virtual DbSet<wrt_i_passenger> wrt_i_passenger { get; set; }
        public virtual DbSet<wrt_i_per> wrt_i_per { get; set; }
        public virtual DbSet<wrt_i_route> wrt_i_route { get; set; }
        public virtual DbSet<wrt_i_station> wrt_i_station { get; set; }
        public virtual DbSet<wrt_i_substation> wrt_i_substation { get; set; }
        public virtual DbSet<wrt_i_suggestion> wrt_i_suggestion { get; set; }
        public virtual DbSet<wrt_i_ticket> wrt_i_ticket { get; set; }
        public virtual DbSet<wrt_t_schedule> wrt_t_schedule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<wrt_i_bus>()
                .Property(e => e.id_bus)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_bus>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_bus>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_driver>()
                .Property(e => e.id_driver)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_driver>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_driver>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_driver>()
                .HasMany(e => e.wrt_t_schedule)
                .WithRequired(e => e.wrt_i_driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.id_employer)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.id_group_per)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.e_mail)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.pass)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_employer>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_group_per>()
                .Property(e => e.id_group_per)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_group_per>()
                .Property(e => e.id_per)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_group_per>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_passenger>()
                .Property(e => e.id_passenger)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_passenger>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_passenger>()
                .Property(e => e.e_mail)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_passenger>()
                .Property(e => e.pass)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_passenger>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_passenger>()
                .HasOptional(e => e.wrt_i_suggestion)
                .WithRequired(e => e.wrt_i_passenger);

            modelBuilder.Entity<wrt_i_passenger>()
                .HasMany(e => e.wrt_i_ticket)
                .WithRequired(e => e.wrt_i_passenger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wrt_i_per>()
                .Property(e => e.id_per)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_per>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_per>()
                .Property(e => e.content_per)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_route>()
                .Property(e => e.id_route)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_route>()
                .Property(e => e.id_origin)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_route>()
                .Property(e => e.id_destinate)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_route>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_route>()
                .HasMany(e => e.wrt_t_schedule)
                .WithRequired(e => e.wrt_i_route)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wrt_i_station>()
                .Property(e => e.id_station)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_station>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_station>()
                .HasMany(e => e.wrt_i_route)
                .WithRequired(e => e.wrt_i_station)
                .HasForeignKey(e => e.id_origin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wrt_i_station>()
                .HasMany(e => e.wrt_i_route1)
                .WithRequired(e => e.wrt_i_station1)
                .HasForeignKey(e => e.id_destinate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<wrt_i_substation>()
                .Property(e => e.id_substation)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_substation>()
                .Property(e => e.phone)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_substation>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_i_substation>()
                .Property(e => e.id_station)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_suggestion>()
                .Property(e => e.id_passenger)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_ticket>()
                .Property(e => e.id_ticket)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_ticket>()
                .Property(e => e.id_schedule)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_ticket>()
                .Property(e => e.id_passenger)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_ticket>()
                .Property(e => e.number_seat)
                .IsFixedLength();

            modelBuilder.Entity<wrt_i_ticket>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_t_schedule>()
                .Property(e => e.id_schedule)
                .IsFixedLength();

            modelBuilder.Entity<wrt_t_schedule>()
                .Property(e => e.id_route)
                .IsFixedLength();

            modelBuilder.Entity<wrt_t_schedule>()
                .Property(e => e.id_driver)
                .IsFixedLength();

            modelBuilder.Entity<wrt_t_schedule>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wrt_t_schedule>()
                .Property(e => e.id_bus)
                .IsFixedLength();

            modelBuilder.Entity<wrt_t_schedule>()
                .HasMany(e => e.wrt_i_ticket)
                .WithRequired(e => e.wrt_t_schedule)
                .WillCascadeOnDelete(false);
        }
    }
}
