using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProtesto.Models
{
    public class ProtestoRepositorio : IProtestoRepositorio
    {
        private readonly ProtestoContext _context;

        public ProtestoRepositorio(ProtestoContext context)
        {
            _context = context;
            Add(new Protesto
            {
                //Id = 1,
                NomeDevedor = "MARCO ANTONIO DO CEU MOTA",
                /*CodigoBanco = 998,
                CodigoInterno = 185011000295,
                NomeCredor = "BANCO ITAUCARD S/A",
                NumeroTitulo = 777725664,
                Parcela = 11,
                NomeDevedor = "MARCO ANTONIO DO CEU MOTA",
                CPF_CNPJ_Devedor = "072.895.717-54",
                Endereco_Devedor = "ESTRADA COMANDANTE LUIZ SOUTO",
                Bairro_Devedor = "494  CS 105",
                Cidade_Devedor = "RIO DE JANEIRO",
                CEP_Devedor = 22733040,
                UF_Devedor = "RJ",
                Cidade_Praca_Pagamento = "RIO DE JANEIRO",
                UF_Praca_Pagamento = "RJ",
                ValorTitulo = 60515.8,
                ValorProtestar = 3464.82,
                DataEmissao = "21/07/2017",
                DataVencimento = "27/06/2018",
                TipoDocumento = "27/06/2018",
                Operacao = "P",
                Valor1aParcela = 1082.1,
                QtdeParcelaContrato = 48, */
                Status = "A"
            }); 
        }
        public IEnumerable<Protesto> GetAll()
        {
            return _context.Protestos.ToList();
        }
        public void Add(Protesto item)
        {
            _context.Protestos.Add(item);
            _context.SaveChanges();
        }
        public Protesto Find(long key)
        {
            return _context.Protestos.FirstOrDefault(t => t.CodigoInterno == key);
        }
        public void Remove(long key)
        {
            var entity = _context.Protestos.First(t => t.CodigoInterno == key);
            _context.Protestos.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Protesto item)
        {
            _context.Protestos.Update(item);
            _context.SaveChanges();
        }
    }
}
