namespace ControleEstoque.WebAPI
{
    public class Funcionario : Pessoa
    {
        public Cargo Cargo { get; private set; }
        public Funcionario(string nome, string sobrenome, string cpf, string telefone, string endereco, Cargo cargo)
            : base(nome, sobrenome, cpf, telefone, endereco)
        {
            Cargo = cargo;
        }
    }
}
