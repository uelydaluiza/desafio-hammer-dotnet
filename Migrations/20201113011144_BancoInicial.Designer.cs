﻿// <auto-generated />
using BarbecueChallengeDotNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarbecueChallengeDotNet.Migrations
{
    [DbContext(typeof(ParticipantContext))]
    [Migration("20201113011144_BancoInicial")]
    partial class BancoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("BarbecueChallengeDotNet.Models.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<bool>("SeCancelado");

                    b.Property<bool>("SeConvidado");

                    b.Property<bool>("SeEmpregado");

                    b.Property<bool>("SeVaiBeber");

                    b.HasKey("Id");

                    b.ToTable("Participant");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Ana Flávia",
                            SeCancelado = false,
                            SeConvidado = true,
                            SeEmpregado = false,
                            SeVaiBeber = true
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Ayrton Souza",
                            SeCancelado = false,
                            SeConvidado = true,
                            SeEmpregado = false,
                            SeVaiBeber = false
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Maria Eduarda",
                            SeCancelado = false,
                            SeConvidado = false,
                            SeEmpregado = true,
                            SeVaiBeber = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}