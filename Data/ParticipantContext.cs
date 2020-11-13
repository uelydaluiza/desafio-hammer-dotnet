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
                new Participante { Id = 1, Nome = "Ana Flávia", SeConvidado = true, SeVaiBeber = true, SeEmpregado = false, SeCancelado = false },
                new Participante { Id = 2, Nome = "Ayrton Souza", SeConvidado = true, SeVaiBeber = false, SeEmpregado = false, SeCancelado = false },
                new Participante { Id = 3, Nome = "Maria Eduarda", SeConvidado = false, SeVaiBeber = true, SeEmpregado = true, SeCancelado = false });
        }
    }
}
