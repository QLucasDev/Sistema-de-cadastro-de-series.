using Entities.Enum;
namespace Entities
{
    public class Serie : EntidadeBase
    {
        private Genero Genero{ get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }


        
        public Serie (int id, Genero gen, string titulo, string descricao, int ano)
        {
            Id = Id;
            Genero = gen;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }

        public int retornaId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }

        public bool retornaExcluido()
        {
            return Excluido;
        }

        public override string ToString()
        {
            string retorno ="";
            retorno += "Genero: " + Genero + "\n";
            retorno += "Titulo: " + Titulo + "\n";
            retorno += "Descrição: " + Descricao + "\n";
            retorno += "Ano de início: " + Ano + "\n";
            retorno += "Excluido: " + Excluido;
            return retorno;
        }
    }
}