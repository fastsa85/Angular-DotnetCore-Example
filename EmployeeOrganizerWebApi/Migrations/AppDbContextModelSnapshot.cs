// <auto-generated />
using System;
using EmployeeOrganizerWebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeOrganizerWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeOrganizerWebApi.Models.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = new Guid("00000001-20db-4800-8d19-c7f7162900ec"),
                            DepartmentName = "Finance"
                        },
                        new
                        {
                            DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                            DepartmentName = "Sales"
                        },
                        new
                        {
                            DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"),
                            DepartmentName = "Engineering"
                        },
                        new
                        {
                            DepartmentId = new Guid("00000004-20db-4800-8d19-c7f7162900ec"),
                            DepartmentName = "Manufacturing"
                        },
                        new
                        {
                            DepartmentId = new Guid("00000005-20db-4800-8d19-c7f7162900ec"),
                            DepartmentName = "Management"
                        });
                });

            modelBuilder.Entity("EmployeeOrganizerWebApi.Models.Employee", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoFileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = new Guid("00000001-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Bilbo Baggins",
                            PhotoFileName = "Bilbo Baggins00000005-20db-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000002-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000004-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Tom Sawyer",
                            PhotoFileName = "Tom Sawyer00000002-1111-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000003-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Alice Wonderland",
                            PhotoFileName = "Alice Wonderland00000003-1111-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000004-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000002-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Jack Sparrow",
                            PhotoFileName = "Jack Sparrow00000004-1111-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000005-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2017, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000005-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "John Snow",
                            PhotoFileName = "John Snow00000005-1111-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000006-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2018, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Stephen King",
                            PhotoFileName = "Stephen King00000006-1111-4800-8d19-c7f7162900ec.jpg"
                        },
                        new
                        {
                            EmployeeId = new Guid("00000007-1111-4800-8d19-c7f7162900ec"),
                            DateOfJoining = new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = new Guid("00000003-20db-4800-8d19-c7f7162900ec"),
                            EmployeeName = "Anna Karenina",
                            PhotoFileName = "Stephen King00000007-1111-4800-8d19-c7f7162900ec.jpg"
                        });
                });

            modelBuilder.Entity("EmployeeOrganizerWebApi.Models.Employee", b =>
                {
                    b.HasOne("EmployeeOrganizerWebApi.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
