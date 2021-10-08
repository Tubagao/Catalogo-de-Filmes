namespace Tuba.Filmes
{
    //Atributos do programa
    public class Serie : EntidadeBase
    {
       private Genero Genero {get; set;} 

       private string Titulo {get; set;} 

       private string Descricao {get; set;} 

       private int Ano {get; set;} 

       private bool Excluido {get; set;}
       
       //Métodos do programa
       public Serie(int id, Genero Genero, string título, string Descricao, int Ano)
       {  
         this.id = id;
         this.Genero = Genero;
         this.Titulo = Titulo;
         this.Descricao = Descricao;
         this.Ano = Ano; 
         this.Excluido = false;
       }

       public override string ToString()
       {
           //Environment.Newline https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
           string retorno = "";
           retorno += "Gênero: " + this.Genero + Environment.Newline;
           retorno += "Título: " + this.Titulo + Environment.Newline;
           retorno += "Descrição: " + this.Descricao + Environment.Newline;
           retorno += "Ano de Início: " + this.Ano;
           return retorno;
       }

       public string retornaTitulo()
       {
           return this.Titulo;
       }
       
       internal int retornaId()
       {
           return this.Id;
       }
       public void Excluir() {
           this.Excluido = true
       }
    }
}