using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_44334.Model
{
    public class Tratamento
    {
        public int Id { get; set; }

        public int IdPaciente { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }
    }
}
