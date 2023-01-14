using Sistema_lojaKX.Models.Enums;

namespace Sistema_lojaKX.Models
{
    public class PurchaseModel
    {
        public int Id { get; set; }
        public string? CPF { get; set; }
        public double Value { get; set; }
        public PurchaseStatus Status { get; set; }
        public string? Product { get; set; }
    }
}
