namespace CodeFirst.Models
{
    public class Detail
    {
        public int IdDetails { get; set; }
        public int Products_idProduct { get; set; }
        public int Invoices_idInvoices { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
    }
}
