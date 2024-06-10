namespace SoftITO.Project.Models
{
    public class Member
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string MembershipNumber { get; set; }
        public string Gender { get; set; }
        public string MembershipStatus { get; set; }
        public string PhoneNumber { get; set; }
        public List<BookCopy> OverdueBooks { get; set; } = new List<BookCopy>();
        public List<BookCopy> BorrowedBooks { get; set; } = new List<BookCopy>();

        public DateTime BirthDate { get; set; }
        public List<Book> ReadBooks { get; set; } = new List<Book>();
        public DateTime MembershipDate { get; set; }

    }
}
