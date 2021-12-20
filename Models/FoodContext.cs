using Microsoft.EntityFrameworkCore;

#nullable disable

namespace RepoPattern.Models
{
    public partial class FoodContext : DbContext
    {
        public FoodContext()
        {
        }

        public FoodContext(DbContextOptions<FoodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bonu> Bonus { get; set; }
        public virtual DbSet<Interview> Interviews { get; set; }
        public virtual DbSet<TblListoffood> TblListoffoods { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-G3B94GU\\SQLEXPRESS;Database=Food;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bonu>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BonusAmount).HasColumnName("BONUS_AMOUNT");

                entity.Property(e => e.BonusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("BONUS_DATE");

                entity.Property(e => e.WorkerRefId).HasColumnName("WORKER_REF_ID");

                entity.HasOne(d => d.WorkerRef)
                    .WithMany()
                    .HasForeignKey(d => d.WorkerRefId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Bonus__WORKER_RE__5DCAEF64");
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("interview");

                entity.Property(e => e.CompanyName)
                    .IsUnicode(false)
                    .HasColumnName("company_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblListoffood>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_listoffood");

                entity.Property(e => e.Categorie)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("categorie");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Img)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PkId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pk_id");

                entity.Property(e => e.Price)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.Status)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Y')");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.WorkerId).HasColumnName("WORKER_ID");

                entity.Property(e => e.Department)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT")
                    .IsFixedLength(true);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME")
                    .IsFixedLength(true);

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("JOINING_DATE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary).HasColumnName("SALARY");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
