using BarbecueChallengeDotNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarbecueChallengeDotNet.Data
{
    public class ParticipantContext : DbContext
    {
        public ParticipantContext(DbContextOptions<ParticipantContext> options) : base(options)
        {

        }

        public virtual DbSet<Participante> Participant { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participante>().HasData(
                new Participante { Id = 1, Nome = "Teste 1", SeConvidado = true, SeVaiBeber = true, SeEmpregado = false, SeCancelado = false },
                new Participante { Id = 2, Nome = "Teste 2", SeConvidado = false, SeVaiBeber = false, SeEmpregado = true, SeCancelado = true },
                new Participante { Id = 3, Nome = "Teste 3", SeConvidado = true, SeVaiBeber = false, SeEmpregado = false, SeCancelado = true },
                new Participante { Id = 4, Nome = "Teste 4", SeConvidado = true, SeVaiBeber = true, SeEmpregado = false, SeCancelado = true },
                new Participante { Id = 5, Nome = "Teste 5", SeConvidado = false, SeVaiBeber = true, SeEmpregado = true, SeCancelado = false },
                new Participante { Id = 6, Nome = "Teste 6", SeConvidado = false, SeVaiBeber = true, SeEmpregado = true, SeCancelado = true },
                new Participante { Id = 7, Nome = "Teste 7", SeConvidado = false, SeVaiBeber = false, SeEmpregado = true, SeCancelado = true });
        }
    }
}
