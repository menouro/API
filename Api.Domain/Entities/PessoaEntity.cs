namespace Api.Domain.Entities
{
    public class PessoaEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Estado { get; set; }
        public int Cidade { get; set; }
        public string Email { get; set; }

    }
}
