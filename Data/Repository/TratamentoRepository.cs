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
    public class TratamentoRepository : ITratamentoRepository
    {
        public void IncluirTratamento(Tratamento tratamento)
        {
            TratamentoDao.Instance.Incluir(tratamento);
        }

        public IEnumerable<Tratamento> ListasTratamentoPorPacientes(int pacienteId)
        {
            var tratamentos = TratamentoDao.Instance.Listar();
            var tratamentosPorPaciente = tratamentos.Where(t => t.IdPaciente == pacienteId);
            return tratamentosPorPaciente;
        }

        internal IEnumerable<Tratamento> ConsultarTodosTratamentos()
        {
            return TratamentoDao.Instance.Listar();
        }
    }
}
