using Infra;
using Infra.Entidades;
using Repositorio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorio
{
    public class ProcessoService : IProcessoService
    {

        Contexto db ;

        public ProcessoService()
        {
                CriarVerificaBD();
            
        }

        /// <summary>
        /// Varifica Existencia do Banco de dados Para a criação do mesmo e inserção dos Dados
        /// </summary>
        public void CriarVerificaBD()
        {
            db = new Contexto();
            if (db.Database.EnsureCreated())
            {
                new DataSeeder().SeedEstado(db);
                new DataSeeder().SeedEmpresas(db);
                new DataSeeder().SeedProcessos(db);
            }
        }

        public List<Processo> ObterListaDeProcessosMesmoEstado()
        {
            return db.Empresa.SelectMany(x => x._Processos.Where(c=>c.EstadoId == x.EstadoId)).ToList();
        }

        public List<Processo> ObterListaDeProcessosPorMesAno(string Mes, string Ano)
        {
            string filtro = Mes + Ano;
            return db.Processo.Where(x => x.Datainicio.ToString("MMyyyy") == filtro).ToList();
        }

        public List<Processo> ObterListaDeProcessosProSigla(string Sigla)
        {
            return db.Processo.Where(x => x.Numero.Contains(Sigla)).ToList();
        }

        public decimal RetornaMediaValores(int EmpresaId, string UF)
        {
            decimal valores = db.Processo.Where(x =>  x.EmpresaId == EmpresaId && x._Estado.Sigla == UF).Sum(x => x.Valor);
            int soma = db.Processo.Count(x =>  x.EmpresaId == EmpresaId && x._Estado.Sigla == UF);

            return (valores / soma);
        }

        public int RetornaProcessosComValoresAcima(decimal Valor)
        {          
            return db.Processo.Count(x => x.Valor > Valor);
        }

        public decimal RetornaValorProcessos(bool Ativos)
        {           
            return db.Processo.Where(x=>x.Ativo == Ativos).Sum(x=>x.Valor);
        }
    }
}
