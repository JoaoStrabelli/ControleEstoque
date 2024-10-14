namespace ControleEstoque.WebAPI
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public string Descricao { get; set; }
        public float SalarioBase { get; set; }
        public Cargo(int id, string descricao, float salarioBase)
        {
            CargoID = id;
            Descricao = descricao;
            SalarioBase = salarioBase;
        }
    }
}

