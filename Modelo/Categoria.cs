namespace ControleEstoque.WebAPI.Modelo
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Categoria(int id, string nome, string descricao)
        {
            CategoriaID = id;
            Nome = nome;
            Descricao = descricao;
        }

        public Categoria() { }
    }
}
