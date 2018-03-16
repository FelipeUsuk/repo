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
    public class TratamentoDao : Dao<Tratamento>
    {
        private static readonly Lazy<TratamentoDao> lazy
           = new Lazy<TratamentoDao>(() => new TratamentoDao());
        public static TratamentoDao Instance { get { return lazy.Value; } }

        string connectionString = ConfigurationManager.ConnectionStrings["DbClinica"].ConnectionString;
        private TratamentoDao() { }

        public override void Incluir(Tratamento entidade)
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                conexao.Execute("Insert into TbTratamentos values(@idpaciente, @descricao, @preco)", entidade);
            }
        }

        public override IEnumerable<Tratamento> Listar()
        {
            using (var conexao = new SqlConnection(connectionString))
            {
                var queryResult = conexao.Query<Tratamento>("select * from TbTratamentos");
                return queryResult;
            }
        }
    }
}
