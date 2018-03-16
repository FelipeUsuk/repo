using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Avaliacao_44334.Data.DAO

{
    public abstract class Dao<T>
    {
        public abstract void Incluir(T entidade);
        public abstract IEnumerable<T> Listar();
    }
}
