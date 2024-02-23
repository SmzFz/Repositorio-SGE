﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGE.Data;

#nullable disable

namespace SGE.Migrations
{
    [DbContext(typeof(SGEContext))]
    [Migration("20240222182405_teste")]
    partial class teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SGE.Models.Aluno", b =>
                {
                    b.Property<Guid>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlunoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TipoUsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UrlFoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Aluno", (string)null);
                });

            modelBuilder.Entity("SGE.Models.AlunoTurma", b =>
                {
                    b.Property<Guid>("AlunoTurmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TurmaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AlunoTurmaId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("AlunoTurma", (string)null);
                });

            modelBuilder.Entity("SGE.Models.Ocorrencia", b =>
                {
                    b.Property<Guid>("OcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFinalizado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataOcorrencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Finalizado")
                        .HasColumnType("bit");

                    b.Property<Guid>("TipoOcorrenciaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tratativa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OcorrenciaId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("TipoOcorrenciaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ocorrencia", (string)null);
                });

            modelBuilder.Entity("SGE.Models.ReservaSala", b =>
                {
                    b.Property<Guid>("ReservaSalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<string>("CorReserva")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DataFimReserva")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DataReserva")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("HoraFim")
                        .HasColumnType("time");

                    b.Property<TimeOnly>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<Guid>("SalaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReservaSalaId");

                    b.HasIndex("SalaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("ReservaSala", (string)null);
                });

            modelBuilder.Entity("SGE.Models.Sala", b =>
                {
                    b.Property<Guid>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<string>("SalaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaId");

                    b.ToTable("Sala", (string)null);
                });

            modelBuilder.Entity("SGE.Models.TipoOcorrencia", b =>
                {
                    b.Property<Guid>("TipoOcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoOcorrenciaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoOcorrenciaId");

                    b.ToTable("TipoOcorrencia", (string)null);
                });

            modelBuilder.Entity("SGE.Models.TipoUsuario", b =>
                {
                    b.Property<Guid>("TipoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoUsuarioId");

                    b.ToTable("TipoUsuario", (string)null);
                });

            modelBuilder.Entity("SGE.Models.Turma", b =>
                {
                    b.Property<Guid>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TurmaEncerrada")
                        .HasColumnType("bit");

                    b.Property<string>("TurmaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurmaId");

                    b.ToTable("Turma", (string)null);
                });

            modelBuilder.Entity("SGE.Models.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CadAtivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CadInativo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TipoUsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("SGE.Models.Aluno", b =>
                {
                    b.HasOne("SGE.Models.TipoUsuario", "TipoUsuario")
                        .WithMany("Alunos")
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("SGE.Models.AlunoTurma", b =>
                {
                    b.HasOne("SGE.Models.Aluno", "Aluno")
                        .WithMany("AlunoTurmas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGE.Models.Turma", "Turma")
                        .WithMany("AlunoTurmas")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Turma");
                });

            modelBuilder.Entity("SGE.Models.Ocorrencia", b =>
                {
                    b.HasOne("SGE.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGE.Models.TipoOcorrencia", "TipoOcorrencia")
                        .WithMany()
                        .HasForeignKey("TipoOcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGE.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("TipoOcorrencia");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SGE.Models.ReservaSala", b =>
                {
                    b.HasOne("SGE.Models.Sala", "Sala")
                        .WithMany("Reservas")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SGE.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SGE.Models.Usuario", b =>
                {
                    b.HasOne("SGE.Models.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("SGE.Models.Aluno", b =>
                {
                    b.Navigation("AlunoTurmas");
                });

            modelBuilder.Entity("SGE.Models.Sala", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("SGE.Models.TipoUsuario", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("SGE.Models.Turma", b =>
                {
                    b.Navigation("AlunoTurmas");
                });
#pragma warning restore 612, 618
        }
    }
}
