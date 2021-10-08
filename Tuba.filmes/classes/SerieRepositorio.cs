using System;
using System.Collections.Generic;
using Tuba.Filmes.Interfaces;

namespace Tuba.Filmes
{
   
   public class SerieRepositorio : IRepositorio<Serie>
  {
        private List<Serie> listaSerie = new List<Serie>();

		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie serie)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}
	}
} 