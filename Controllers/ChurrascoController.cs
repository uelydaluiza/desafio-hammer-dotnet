using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarbecueChallengeDotNet.Data;
using BarbecueChallengeDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BarbecueChallengeDotNet.Controllers
{
    [Route("api/churrasco")]
    [ApiController]
    public class ChurrascoController : ControllerBase
    {

        private readonly ParticipantContext _banco;

        public ChurrascoController(ParticipantContext banco)
        {
            _banco = banco;
        }

        //Insere participantes, seja convidados ou empregados
        [HttpPost]
        [Route("CriarParticipante")]
        public async Task<int> AdicinarPost([FromBody] Participante participante)
        {
            await _banco.Participant.AddAsync(participante);
            await _banco.SaveChangesAsync();
            return participante.Id;
        }

        //Retorna todos os candidatos 
        [HttpGet]
        [Route("RetornaConvidados")]

        public async Task<IEnumerable<Participante>> GetConvidados()
        {
            return await _banco.Participant.Where(g => g.SeCancelado == false && g.SeConvidado == true).ToListAsync();
        }

        //Retorna todos os empregados da empresa que irão participar do churrasco
        [HttpGet]
        [Route("RetornaEmpregados")]

        public async Task<IEnumerable<Participante>> GetEmpregados()
        {
           return await _banco.Participant.Where(e => e.SeCancelado == false && e.SeEmpregado == true).ToListAsync();
        }

        //Remove participante do churrasco
        [HttpPut("{id}")]
        [Route("RemoveParticipante/{id}")]
        public async Task<Participante> DeleteParticipante(int id)
        {
            var remover = await _banco.Participant.FindAsync(id);
            if (remover.SeCancelado == false)
            {
                remover.SeCancelado = true;
                await _banco.SaveChangesAsync();
            }
            return remover;


        }

        //Retorna todas as pessoas que cancelaram suas participações
        [HttpGet]
        [Route("RetornaCancelados")]

        public async Task<IEnumerable<Participante>> GetCancelados()
        {
            return await _banco.Participant.Where(e => e.SeCancelado == true).ToListAsync();
        }

        //Retorna o total arrecadado
        [HttpGet]
        [Route("RetornaTotalArrecadado")]

        public ActionResult GetTotalArrecadado()
        {
            var quembebe = _banco.Participant.Count(c => c.SeVaiBeber == true && c.SeCancelado == false);
            var totalquembebe = quembebe * 20;

            var naovaibeber = _banco.Participant.Count(c => c.SeVaiBeber == false && c.SeCancelado == false);
            var totalnaobebe = naovaibeber * 10;
            var totalarrecadado = totalnaobebe + totalquembebe;

            return Ok(totalarrecadado);

        }

        //Retorna o total gasto em bebidas. Considerando que o valor da bebida para qualquer pessoa é 10 reais
        [HttpGet]
        [Route("RetornaTotalBebida")]

        public ActionResult GetTotalBebida()
        {
            var qtd = _banco.Participant.Count(c => c.SeVaiBeber == true && c.SeCancelado == false);
            var total = qtd * 10;

            return Ok(total);

        }

        //Retorna o total gasto em comida. Considerando que o valor da comida para qualquer pessoa é 10 reais
        [HttpGet]
        [Route("RetornaTotalComida")]

        public ActionResult GetTotalComida()
        {
            var qtd = _banco.Participant.Count(c => c.SeCancelado == false);
            var total = qtd * 10;

            return Ok(total);

        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Running" };
        }




  
    }
}
