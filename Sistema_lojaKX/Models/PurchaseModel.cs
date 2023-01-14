namespace Sistema_lojaKX.Models
{
    public class PurchaseModel
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public string? Product { get; set; }
        public string? ClientCPF { get; set; }
        public virtual ClientModel? Client { get; set; }
    }
}
