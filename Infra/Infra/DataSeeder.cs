using Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infra
{
    public class DataSeeder
    {

        public  void SeedEstado(Contexto context)
        {
            if (context.Estado.Count() == 0)
            {
                var _Etados = new List<Estado>
            {
                new Estado {Id = 1, Sigla = "RJ", NomeEstado = "Rio de Janeiro" },
                new Estado {Id = 2, Sigla = "SP", NomeEstado = "São Paulo" },
                new Estado {Id = 3, Sigla = "MG", NomeEstado = "Minas Gerais" },
                new Estado {Id = 4, Sigla = "AM", NomeEstado = "Amazonas" }

            };
                context.AddRange(_Etados);
                context.SaveChanges();
            }
        }

        public  void SeedEmpresas(Contexto context)
        {
            if (context.Empresa.Count() == 0)
            {
                var _Empresas = new List<Empresa>
            {
                new Empresa {EmpresaId = 1,Cnpj = "00000000000001",RazaoSocial = "Empresa A",EstadoId = 1 },
                new Empresa {EmpresaId = 2,Cnpj = "00000000000002", RazaoSocial = "Empresa B", EstadoId = 2 },

            };
                context.AddRange(_Empresas);
                context.SaveChanges();
            }
        }

        public void SeedProcessos(Contexto context)
        {
            if (context.Processo.Count() == 0)
            {
                var _Processo = new List<Processo>
            {
                /// DADOS PARA EMPRESA 1

                new Processo {EmpresaId = 1, Datainicio = Convert.ToDateTime("10/10/2007"),EstadoId = 1,Numero = "00001CIVELRJ",Valor = 200000.00M, Ativo = true},
                new Processo {EmpresaId = 1, Datainicio = Convert.ToDateTime("20/10/2007"),EstadoId = 2,Numero = "00002CIVELSP",Valor = 100000.00M, Ativo = true},
                new Processo {EmpresaId = 1, Datainicio = Convert.ToDateTime("30/10/2007"),EstadoId = 3,Numero = "00003TRABMG",Valor = 10000.00M, Ativo = false},
                new Processo {EmpresaId = 1, Datainicio = Convert.ToDateTime("10/11/2007"),EstadoId = 1,Numero = "00004CIVELRJ",Valor = 20000.00M, Ativo = false},
                new Processo {EmpresaId = 1, Datainicio = Convert.ToDateTime("15/11/2007"),EstadoId = 2,Numero = "00005CIVELSP",Valor = 35000.00M, Ativo = true},
                
                /// DADOS PARA EMPRESA 2

                new Processo {EmpresaId = 2, Datainicio = Convert.ToDateTime("01/05/2007"),EstadoId = 1,Numero = "00006CIVELRJ",Valor = 20000.00M, Ativo = true},
                new Processo {EmpresaId = 2, Datainicio = Convert.ToDateTime("02/06/2007"),EstadoId = 1,Numero = "00007CIVELRJ",Valor = 700000.00M, Ativo = true},
                new Processo {EmpresaId = 2, Datainicio = Convert.ToDateTime("03/07/2007"),EstadoId = 2,Numero = "00008CIVELSP",Valor = 500.00M, Ativo = false},
                new Processo {EmpresaId = 2, Datainicio = Convert.ToDateTime("04/08/2007"),EstadoId = 2,Numero = "00009CIVELSP",Valor = 32000.00M, Ativo = true},
                new Processo {EmpresaId = 2 , Datainicio = Convert.ToDateTime("05/09/2007"),EstadoId = 4,Numero = "00010TRABAM",Valor = 1000.00M, Ativo = false}
            };
                context.AddRange(_Processo);
                context.SaveChanges();
            }
        }
    }
}
