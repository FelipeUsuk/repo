using Fiap.PlataformaNet.Avaliacao_44334.Data.DAO;
using Fiap.PlataformaNet.Avaliacao_44334.Data.Interface;
using Fiap.PlataformaNet.Avaliacao_44334.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_44334.Data.Repository
{
    public class PacienteRepository : IPacienteRepository
    {


        public void CadastrarPaciente(Paciente paciente)
        {
            PacienteDao.Instance.Incluir(paciente);
        }

        public IEnumerable<Paciente> ConsultarTodosPacientes()
        {
            return PacienteDao.Instance.Listar();
        }
    }
}
