using Fiap.PlataformaNet.Avaliacao_44334.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_44334.Data.Interface
{
    interface IPacienteRepository
    {
        void CadastrarPaciente(Paciente paciente);
        IEnumerable<Paciente> ConsultarTodosPacientes();
    }
}
