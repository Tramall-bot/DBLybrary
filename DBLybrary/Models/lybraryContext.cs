using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBLybrary.Models
{
    public partial class lybraryContext : DbContext
    {
        public lybraryContext()
        {
        }

        public lybraryContext(DbContextOptions<lybraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<ReturnedBooks> ReturnedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Sourse = LENOVO-PC; Database=Dblybrary; Trusted_Connection=True;");
                //optionsBuilder.UseSqlite("Data Source=C:\\Users\\Алексей\\Downloads\\SQLiteStudio\\DB\\lybrary.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BkId);

                entity.Property(e => e.BkId)
                    .HasColumnName("Bk_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.BkAuthor)
                    .IsRequired()
                    .HasColumnName("Bk_Author")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.BkName)
                    .IsRequired()
                    .HasColumnName("Bk_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.BkRealiseDate)
                    .IsRequired()
                    .HasColumnName("Bk_Realise_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.GenId)
                    .HasColumnName("Gen_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.PubId)
                    .HasColumnName("Pub_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Gen)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.GenId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PubId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasColumnName("Emp_Address")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.EmpAge)
                    .HasColumnName("Emp_Age")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpFullName)
                    .IsRequired()
                    .HasColumnName("Emp_Full_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.EmpPassportData)
                    .IsRequired()
                    .HasColumnName("Emp_Passport_Data")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.EmpPhoneNumber)
                    .IsRequired()
                    .HasColumnName("Emp_Phone_Number")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.EmpSex)
                    .IsRequired()
                    .HasColumnName("Emp_Sex")
                    .HasColumnType("CHAR");

                entity.Property(e => e.PosId)
                    .HasColumnName("Pos_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenId);

                entity.Property(e => e.GenId)
                    .HasColumnName("Gen_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenDescription)
                    .IsRequired()
                    .HasColumnName("Gen_Description")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.GenName)
                    .IsRequired()
                    .HasColumnName("Gen_Name")
                    .HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.Property(e => e.PosId)
                    .HasColumnName("Pos_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosDuties)
                    .IsRequired()
                    .HasColumnName("Pos_Duties")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PosName)
                    .IsRequired()
                    .HasColumnName("Pos_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PosRequirements)
                    .IsRequired()
                    .HasColumnName("Pos_Requirements")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PosSalary)
                    .HasColumnName("Pos_Salary")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PubId);

                entity.Property(e => e.PubId)
                    .HasColumnName("Pub_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.PubAddress)
                    .IsRequired()
                    .HasColumnName("Pub_Address")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PubCity)
                    .IsRequired()
                    .HasColumnName("Pub_City")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.PubName)
                    .IsRequired()
                    .HasColumnName("Pub_Name")
                    .HasColumnType("VARCHAR");
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.HasKey(e => e.RdId);

                entity.Property(e => e.RdId)
                    .HasColumnName("Rd_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.RdAddress)
                    .IsRequired()
                    .HasColumnName("Rd_Address")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.RdBdDate)
                    .IsRequired()
                    .HasColumnName("Rd_BD_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.RdFullName)
                    .IsRequired()
                    .HasColumnName("Rd_Full_Name")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.RdPassportData)
                    .IsRequired()
                    .HasColumnName("Rd_Passport_Data")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.RdPhoneNumber)
                    .IsRequired()
                    .HasColumnName("Rd_Phone_Number")
                    .HasColumnType("VARCHAR");

                entity.Property(e => e.RdSex)
                    .IsRequired()
                    .HasColumnName("Rd_Sex")
                    .HasColumnType("CHAR");
            });

            modelBuilder.Entity<ReturnedBooks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Returned_Books");

                entity.Property(e => e.BkId)
                    .HasColumnName("Bk_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.RbGiveOutDate)
                    .IsRequired()
                    .HasColumnName("Rb_GiveOut_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.RbReturnDate)
                    .IsRequired()
                    .HasColumnName("Rb_Return_Date")
                    .HasColumnType("DATE");

                entity.Property(e => e.RbReturnFlag)
                    .HasColumnName("Rb_Return_Flag")
                    .HasColumnType("INT");

                entity.Property(e => e.RdId)
                    .HasColumnName("Rd_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Bk)
                    .WithMany()
                    .HasForeignKey(d => d.BkId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Emp)
                    .WithMany()
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Rd)
                    .WithMany()
                    .HasForeignKey(d => d.RdId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
