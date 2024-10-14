namespace ControleEstoque.WebAPI
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Cpf { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        public Pessoa(string nome, string sobrenome, string cpf, string telefone, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
            Endereco = endereco;
        }

        public string NomeCompleto()
        {
            return $"{this.Nome} {this.Sobrenome}";
        }
    }
}
