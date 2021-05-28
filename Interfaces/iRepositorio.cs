using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public interface iRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atualizar(int id, T entidade);

        int ProximoId();

    }
}
