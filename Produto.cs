using ControleEstoque.WebAPI.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstoque.WebAPI
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int FornecedorID { get; set; }
        [ForeignKey("FornecedorID")]
        public Fornecedor Fornecedor { get; set; }
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public Categoria Categoria { get; set; }

        public Produto(int id, string nome, string descricao, decimal preco, int quantidadeEstoque, Fornecedor fornecedor, Categoria categoria)
        {
            ProdutoID = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
            Fornecedor = fornecedor;
            Categoria = categoria;
        }
    }
}
