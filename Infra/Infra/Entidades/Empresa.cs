using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Entidades
{
    public class Empresa
    {
        

        public int EmpresaId { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado _Estado { get; set; }
        public virtual IList<Processo> _Processos { get; set; }
    }
}
