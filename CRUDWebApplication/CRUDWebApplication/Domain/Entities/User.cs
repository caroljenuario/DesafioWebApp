namespace CRUDWebApplication.Domain.Entities
{
    public class User : Contact
    {
        public int id { get; set; }
        public int CPF { get; set; }
        public string name { get; set; }

        public string email { get; set; }
        public int CEP { get; set; }
        public string street { get; set; }
        public string complement { get; set; }

        public string district { get; set; }
        public string UF { get; set; }
        List<Contact> contacts { get; set; }

    }
}
