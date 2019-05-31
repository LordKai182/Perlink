using System;

namespace Infra.Entidades
{
   public class Processo
    {
        public int ProcessoId { get; set; }
        public int EmpresaId { get; set; }
        public string Numero { get; set; }
        public int EstadoId { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime Datainicio { get; set; }

        public virtual Empresa _Empresa { get; set; }
        public virtual Estado _Estado { get; set; }
    }
}
