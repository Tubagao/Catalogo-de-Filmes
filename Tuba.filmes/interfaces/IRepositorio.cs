using System.Collections.Generic;

namespace Tuba.Filmes.Interfaces
{


   public interface IRepositorio<T>
   {
       List<T> Lista();

       T RertornaPorId(int id);

       void Insere(T entidade);

       void Exclui(int id);

       void Atualiza(int id, T entidade);

       int ProximoId();

       
   }


}