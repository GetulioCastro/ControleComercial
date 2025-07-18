namespace ControleComercial.Models
{
    public class ClienteModel
    {
        public int ID { get; set; }
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
