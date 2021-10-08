namespace Tuba.Filmes
{
    //Atributos do programa
    public class Serie : EntidadeBase
    {
       private Genero Genero {get; set;} 

       private string Titulo {get; set;} 

       private string Descricao {get; set;} 

       private int Ano {get; set;} 
       
       //Métodos do programa
       public Serie(int id, Genero Genero, string título, string Descricao, int Ano)
       

    }
}