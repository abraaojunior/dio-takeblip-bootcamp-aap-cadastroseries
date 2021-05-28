using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
            //throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
            //throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
            //throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            return listaSerie;
            //throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
            //throw new NotImplementedException();
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
            //throw new NotImplementedException();
        }
    }
}
