namespace SoftITO.Project.Models
{
    public class BookCopy
    {

        public int Id { get; set; }
        public Book Book { get; set; }
        public string UniqueId { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDamaged { get; set; }
        public DateTime? BorrowDate { get; set; }
        public decimal BuyPrice { get; set; }
        public string Publisher { get; set; }
        public string WarehouseInfo { get; set; }
        public Member Borrower { get; set; }
        public Employee DamagedBy { get; set; }

    }
}
