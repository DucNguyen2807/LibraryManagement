using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookLocation> BookLocations { get; set; }
        public virtual DbSet<BorrowRecord> BorrowRecords { get; set; }
        public virtual DbSet<BorrowRequest> BorrowRequests { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LostBook> LostBooks { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewedBook> ViewedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database= LibraryManagement;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ISBN");

                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK__Books__Publisher__4E88ABD4");
            });

            modelBuilder.Entity<BookLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__BookLoca__E7FEA47716A953A2");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.ColumnShelf)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RowShelf)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Shelf)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookLocations)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BookLocat__BookI__5165187F");
            });

            modelBuilder.Entity<BorrowRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__BorrowRe__FBDF78C964A60549");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.BorrowDate).HasColumnType("date");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnStatus)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BorrowRecords)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BorrowRec__BookI__5441852A");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.BorrowRecords)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__BorrowRec__Emplo__72C60C4A");

                entity.HasOne(d => d.MemberCodeNavigation)
                    .WithMany(p => p.BorrowRecords)
                    .HasPrincipalKey(p => p.MemberCode)
                    .HasForeignKey(d => d.MemberCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BorrowRec__Membe__5535A963");
            });

            modelBuilder.Entity<BorrowRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__BorrowRe__33A8519A78BB6478");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BorrowRequests)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BorrowReq__BookI__5EBF139D");

                entity.HasOne(d => d.MemberCodeNavigation)
                    .WithMany(p => p.BorrowRequests)
                    .HasPrincipalKey(p => p.MemberCode)
                    .HasForeignKey(d => d.MemberCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BorrowReq__Membe__5FB337D6");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Idcard)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LostBook>(entity =>
            {
                entity.HasKey(e => e.LostId)
                    .HasName("PK__LostBook__701FC82D80026CAB");

                entity.Property(e => e.LostId).HasColumnName("LostID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.LostDate).HasColumnType("date");

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.LostBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LostBooks__BookI__5812160E");

                entity.HasOne(d => d.MemberCodeNavigation)
                    .WithMany(p => p.LostBooks)
                    .HasPrincipalKey(p => p.MemberCode)
                    .HasForeignKey(d => d.MemberCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LostBooks__Membe__59063A47");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewDate).HasColumnType("date");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reviews__BookID__628FA481");

                entity.HasOne(d => d.MemberCodeNavigation)
                    .WithMany(p => p.Reviews)
                    .HasPrincipalKey(p => p.MemberCode)
                    .HasForeignKey(d => d.MemberCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reviews__MemberC__6383C8BA");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.MemberCode, "UQ__Users__84CA6377D1310787")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Idcard)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("IDCard");

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewedBook>(entity =>
            {
                entity.HasKey(e => e.ViewId)
                    .HasName("PK__ViewedBo__1E371C16CBCCB936");

                entity.Property(e => e.ViewId).HasColumnName("ViewID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ViewedBooks)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ViewedBoo__BookI__66603565");

                entity.HasOne(d => d.MemberCodeNavigation)
                    .WithMany(p => p.ViewedBooks)
                    .HasPrincipalKey(p => p.MemberCode)
                    .HasForeignKey(d => d.MemberCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ViewedBoo__Membe__6754599E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
