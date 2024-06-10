namespace SoftITO.Project.Models
{
    public class Author
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string BookTitle { get; set; }

        public bool Gender { get; set; }
        public string Biography { get; set; }
        public string TwitterHandle { get; set; }
        public string FacebookProfile { get; set; }
        public string InstagramProfile { get; set; }
        public string PhoneNumber { get; set; }
        public string WebsiteOfAuthor { get; set; }

        public List<Book>? Books { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string Nationality { get; set; }
        public List<string> Awards { get; set; } = new List<string>();
        public string PhotoURL { get; set; }
        public string Education { get; set; }

    }
}
