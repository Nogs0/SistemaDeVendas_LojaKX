namespace Sistema_lojaKX.Models
{
    public class PurchaseModel
    {
        public int Id_Purchase { get; set; }
        public int Id_Product { get; set; }
        public int Id_Client { get; set; }
        public string? Cpf_Client { get; set; }

    }
}
