using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositorio.Interface;
using Repositorio.Repositorio;

namespace TesteProcesso
{
    [TestClass]
    public class TesteProcesso
    {
        IProcessoService processoService = new ProcessoService();

        /// <summary>
        /// Calcular a soma dos processos ativos. A aplicação deve retornar R$ 1.087.000,00
        /// </summary>
        [TestMethod]
        public void CasoDeTeste1()
        {
           
            decimal valor = processoService.RetornaValorProcessos(true);

            Assert.AreEqual(1087000.00M, valor);

        }
        /// <summary>
        /// Calcular a a média do valor dos processos no Rio de Janeiro 
        /// para o Cliente "Empresa A". A aplicação deve retornar R$ 110.000,00.
        /// </summary>
        [TestMethod]
        public void CasoDeTeste2()
        {
            decimal valor = processoService.RetornaMediaValores(1,"RJ");

            Assert.AreEqual(110000.00M, valor);

        }

        /// <summary>
        /// Calcular o Número de processos com valor acima de 
        /// R$ 100.000,00. A aplicação deve retornar 2.
        /// </summary>
        [TestMethod]
        public void CasoDeTeste3()
        {
            decimal valor = processoService.RetornaProcessosComValoresAcima(110000.00M);

            Assert.AreEqual(2, valor);

        }

        /// <summary>
        /// Obter a lista de Processos de Setembro de 2007. 
        /// A aplicação deve retornar uma lista com somente o Processo “00010TRABAM”.
        /// </summary>
        [TestMethod]
        public void CasoDeTeste4()
        {
            var Lista = processoService.ObterListaDeProcessosPorMesAno("09","2007");

        }

        /// <summary>
        /// Obter a lista de processos no mesmo estado do cliente, para cada um dos clientes.
        /// A aplicação deve retornar uma lista com os processos de número 
        /// “00001CIVELRJ”,”00004CIVELRJ” para o Cliente "Empresa A" 
        /// e “00008CIVELSP”,”00009CIVELSP” para o o Cliente "Empresa B".
        /// </summary>
        [TestMethod]
        public void CasoDeTeste5()
        {
            var Lista = processoService.ObterListaDeProcessosMesmoEstado();

        }

        /// <summary>
        ///  Obter a lista de processos que contenham a sigla “TRAB”. 
        ///  A aplicação deve retornar uma lista com os processos 
        ///  “00003TRABMG” e “00010TRABAM”
        /// </summary>
        [TestMethod]
        public void CasoDeTeste6()
        {
            var Lista = processoService.ObterListaDeProcessosProSigla("TRAB");

        }
    }
}
