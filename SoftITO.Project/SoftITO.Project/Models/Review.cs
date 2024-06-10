namespace SoftITO.Project.Models
{
    public class Review
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public Book BookName { get; set; }
        public int Likes { get; set; }
        public string LanguageOfReview { get; set; }
        public int Unlikes { get; set; }
        public string WritingStyle { get; set; }
    }
}
