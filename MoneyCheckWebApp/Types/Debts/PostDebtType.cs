namespace MoneyCheckWebApp.Types.Debts
{
    public class PostDebtType
    {
        public long Amount { get; set; }
        public string? Description { get; set; }
        public long? PurchaseId { get; set; }
        public long DebtorId { get; set; }
    }
}