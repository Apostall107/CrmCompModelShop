namespace Crm.BL.Model
{
    public class Selling
    {
        public int Id { get; set; }
        public int ChequeId { get; set; }
        public int ProductId { get; set; }

        public virtual Cheque Cheque { get; set; }
        public virtual Product Product { get; set; }
    }
}