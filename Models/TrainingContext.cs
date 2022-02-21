using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace UniAPI.Models
{
    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
        {
        }

        public TrainingContext(DbContextOptions<TrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Enroll> Enrolls { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Instructorteachescourse> Instructorteachescourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=Training;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("coursename");

                entity.Property(e => e.Credithours).HasColumnName("credithours");

                entity.Property(e => e.Depid).HasColumnName("depid");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.Depid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Courses__depid__6383C8BA");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Depid)
                    .HasName("PK__Departme__00D4AEBB48E0DB12");

                entity.Property(e => e.Depid).HasColumnName("depid");

                entity.Property(e => e.Deploc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("deploc");

                entity.Property(e => e.Depname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("depname");
            });

            modelBuilder.Entity<Enroll>(entity =>
            {
                entity.ToTable("Enroll");

                entity.Property(e => e.Enrollid).HasColumnName("enrollid");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Instid).HasColumnName("instid");

                entity.Property(e => e.Studentid).HasColumnName("studentid");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Courseid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Enroll__courseid__6E01572D");

                entity.HasOne(d => d.Inst)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Instid)
                    .HasConstraintName("FK__Enroll__instid__6EF57B66");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Enrolls)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Enroll__studenti__6D0D32F4");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.Instid)
                    .HasName("PK__Instruct__980ED5CFB595E330");

                entity.Property(e => e.Instid).HasColumnName("instid");

                entity.Property(e => e.Depid).HasColumnName("depid");

                entity.Property(e => e.FName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("f_name");

                entity.Property(e => e.LName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("l_name");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.Depid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Instructo__depid__60A75C0F");
            });

            modelBuilder.Entity<Instructorteachescourse>(entity =>
            {
                entity.ToTable("instructorteachescourse");

                entity.Property(e => e.Courseid).HasColumnName("courseid");

                entity.Property(e => e.Instid).HasColumnName("instid");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Studentid).HasColumnName("studentid");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasComputedColumnSql("(datepart(year,getdate())-datepart(year,[dob]))", false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.FName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("f_name");

                entity.Property(e => e.Gpa)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("gpa");

                entity.Property(e => e.LName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("l_name");

                entity.Property(e => e.MName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("m_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
