namespace ControleEstoque.WebAPI
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public Fornecedor(int id, string nome, string cnpj, string telefone, string endereco, string email)
        {
            FornecedorID = id;
            Nome = nome;
            Cnpj = cnpj;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }
    }
}
