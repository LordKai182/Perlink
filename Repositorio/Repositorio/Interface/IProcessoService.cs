using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Interface
{
    public interface IProcessoService
    {
        /// <summary>
        /// Retorna Valor dos Processos Ativos
        /// </summary>
        /// <param name="Ativos"></param>
        /// <returns></returns>
        decimal RetornaValorProcessos(bool Ativos);

        /// <summary>
        /// Retorna Media de Valores no Processos
        /// </summary>
        /// <param name="EmpresaId"></param>
        /// <param name="UF"></param>
        /// <returns></returns>
        decimal RetornaMediaValores(int EmpresaId, string UF);

        /// <summary>
        /// Retorna Quantidade de Processos com valores acima do Informado
        /// </summary>
        /// <param name="Valor"></param>
        /// <returns></returns>
        int RetornaProcessosComValoresAcima(decimal Valor);

        /// <summary>
        /// Obtem Lista de Processo por Mes e Ano
        /// </summary>
        /// <param name="Mes"></param>
        /// <param name="Ano"></param>
        /// <returns></returns>
        List<Processo> ObterListaDeProcessosPorMesAno(string Mes, string Ano);

        /// <summary>
        /// Obtem Lista de Processo das empresas que estejam no mesmo estado da mesma
        /// </summary>
        /// <returns></returns>
        List<Processo> ObterListaDeProcessosMesmoEstado();

        /// <summary>
        /// Obtem Lista de Processos que contenham a Sigla Passada po parametro
        /// </summary>
        /// <param name="Sigla"></param>
        /// <returns></returns>
        List<Processo> ObterListaDeProcessosProSigla(string Sigla);

    }
}
