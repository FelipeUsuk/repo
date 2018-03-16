using Fiap.PlataformaNet.Avaliacao_44334.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Fiap.PlataformaNet.Avaliacao_44334.Data.DAO
{
    public class PacienteDao : Dao<Paciente>
    {
        private static readonly Lazy<PacienteDao> lazy
           = new Lazy<PacienteDao>(() => new PacienteDao());
        public static PacienteDao Instance { get { return lazy.Value; } }

        string connectionString = ConfigurationManager.ConnectionStrings["DbClinica"].ConnectionString;
        private PacienteDao(){}

        public override void Incluir(Paciente entidade)
        {
            
            using (var conexao = new SqlConnection(connectionString))
            {
                conexao.Execute("Insert into TbPacientes values(@nome, @telefone)", entidade);   
            }
            
        }

        public override IEnumerable<Paciente> Listar()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                var queryResult = conexao.Query<Paciente>("select * from TbPacientes");
                return queryResult;

            }
        }
    }
}
