using System.Security.Cryptography.Pkcs;

namespace SoftITO.Project.Models
{
    public class Publisher
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfEmployees { get; set; }
        public string WebsiteOfPublishinghHouse { get; set; }
        public List<Book> PublishedBooks { get; set; } = new List<Book>();
        public DateTime EstablishmentDate { get; set; }
        public string ContactInformation { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }

    }
}
