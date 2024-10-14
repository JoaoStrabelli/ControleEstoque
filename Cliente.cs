namespace ControleEstoque.WebAPI
{
    public class Cliente : Pessoa
    {
        public DateTime DataCadastro { get; private set; }

        public Cliente(string nome, string sobrenome, string cpf, string telefone, string endereco)
            : base(nome, sobrenome, cpf, telefone, endereco)
        {
            DataCadastro = DateTime.Now;
        }
    }
}
