namespace SoftITO.Project.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public List<Publisher> Publishers { get; set; } = new List<Publisher>();
        public List<string> Categories { get; set; } = new List<string>();
        public List<string> Languages { get; set; } = new List<string>();
        public int PageCount { get; set; }
        public int PageSize { get; set;}
        public string BookTranslator { get; set; }
        public int RentalCount { get; set; }
        public double Rating { get; set; }
        public double Weight { get; set; }
        public int Edition { get; set; }
        public bool Deleted { get; set; }
        public bool Uptaded { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<string> Awards { get; set; } = new List<string>();
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string TargetAgeGroup { get; set; }
        public string ImageURL { get; set; }
        public string ISBN { get; set; } = "";
        public List<BookCopy> Copies { get; set; } = new List<BookCopy>();
        public DateTime PublicationDate { get; set; }

    }
}
