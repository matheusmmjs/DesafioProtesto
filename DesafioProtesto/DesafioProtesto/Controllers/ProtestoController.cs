using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioProtesto.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesafioProtesto.Controllers
{
    [Route("api/[controller]")]
    public class ProtestoController : Controller
    {
        private readonly IProtestoRepositorio _protestoRepositorio;

        public ProtestoController(IProtestoRepositorio protestoRepositorio)
        {
           // _protestoRepositorio = protestoRepositorio;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var aux = _protestoRepositorio.Find(id);
            if (aux == null)
            {
                return NotFound();
            }
            _protestoRepositorio.Remove(id);
            return new NoContentResult();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Protesto item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }
            var protesto = _protestoRepositorio.Find(id);
            if (protesto == null)
            {
                return NotFound();
            }
            protesto.CodigoBanco = item.CodigoBanco;
            protesto.CodigoInterno = item.CodigoInterno;
            protesto.NomeCredor = item.NomeCredor;
            protesto.NumeroTitulo = item.NumeroTitulo;
            protesto.Parcela = item.Parcela;
            protesto.NomeDevedor = item.NomeDevedor;
            protesto.CPF_CNPJ_Devedor = item.CPF_CNPJ_Devedor;
            protesto.Endereco_Devedor = item.Endereco_Devedor;
            protesto.CodigoInterno = item.CodigoInterno;
            protesto.Bairro_Devedor = item.Bairro_Devedor;
            protesto.Cidade_Devedor = item.Cidade_Devedor;
            protesto.CEP_Devedor = item.CEP_Devedor;
            protesto.UF_Devedor = item.UF_Devedor;
            protesto.Cidade_Praca_Pagamento = item.Cidade_Praca_Pagamento;
            protesto.UF_Praca_Pagamento = item.UF_Praca_Pagamento;
            protesto.ValorTitulo = item.ValorTitulo;
            protesto.ValorProtestar = item.ValorProtestar;
            protesto.DataEmissao = item.DataEmissao;
            protesto.DataVencimento = item.DataVencimento;
            protesto.TipoDocumento = item.TipoDocumento;
            protesto.Operacao = item.Operacao;
            protesto.Valor1aParcela = item.Valor1aParcela;
            protesto.QtdeParcelaContrato = item.QtdeParcelaContrato;
            protesto.Status = item.Status;
            _protestoRepositorio.Update(protesto);
            return new NoContentResult();
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Protesto> GetAll()
        {
            return _protestoRepositorio.GetAll();
        }

        // GET: api/<controller>
        [HttpGet("{id}", Name = "GetProtesto")]
        public IActionResult GetById(long id)
        {
            var item = _protestoRepositorio.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Create([FromBody] Protesto item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _protestoRepositorio.Add(item);
            return CreatedAtRoute("GetProtesto", new { id = item.Id }, item);
        }
    }
}
