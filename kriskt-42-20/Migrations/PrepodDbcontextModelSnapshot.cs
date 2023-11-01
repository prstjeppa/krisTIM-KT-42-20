﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kriskt_42_20.Database;

#nullable disable

namespace kriskt_42_20.Migrations
{
    [DbContext(typeof(PrepodDbcontext))]
    partial class PrepodDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kriskt_42_20.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("degree_id")
                        .HasComment("Идентификатор записи ученой степени");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("Name_degree")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("c_name_degree")
                        .HasComment("Название ученой степени");

                    b.HasKey("DegreeId")
                        .HasName("pk_cd_degree_degree_id");

                    b.ToTable("cd_degree", (string)null);
                });

            modelBuilder.Entity("kriskt_42_20.Models.Kafedra", b =>
                {
                    b.Property<int>("KafedraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Идентификатор записи кафедры")
                        .HasComment("Идентификатор записи кафедры");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KafedraId"));

                    b.Property<string>("KafedraName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("Название кафедры")
                        .HasComment("Название кафедры");

                    b.HasKey("KafedraId")
                        .HasName("pk_cd_kafedra_kafedra_id");

                    b.ToTable("cd_kafedra", (string)null);
                });

            modelBuilder.Entity("kriskt_42_20.Models.Prepod", b =>
                {
                    b.Property<int>("PrepodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prepod_id")
                        .HasComment("Индетификатор записи преподавателя");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrepodId"));

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("c_prepod_firstname")
                        .HasComment("Имя преподавателя");

                    b.Property<int>("KafedraId")
                        .HasColumnType("int")
                        .HasColumnName("kafedra_id")
                        .HasComment("Индетификатор кафедры");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("c_prepod_lastname")
                        .HasComment("Фамилия преподавателя");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("c_prepod_middlename")
                        .HasComment("Отчество преподавателя");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrepodId")
                        .HasName("pk_cd_prepod_prepod_id");

                    b.HasIndex("DegreeId");

                    b.HasIndex(new[] { "KafedraId" }, "idx_cd_prepod_fk_f_kafedra_id");

                    b.ToTable("cd_prepod", (string)null);
                });

            modelBuilder.Entity("kriskt_42_20.Models.Prepod", b =>
                {
                    b.HasOne("kriskt_42_20.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kriskt_42_20.Models.Kafedra", "Kafedra")
                        .WithMany()
                        .HasForeignKey("KafedraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_kafedra_id");

                    b.Navigation("Degree");

                    b.Navigation("Kafedra");
                });
#pragma warning restore 612, 618
        }
    }
}
