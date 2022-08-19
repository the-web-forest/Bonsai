namespace Bonsai.Domain.Errors
{
    [Serializable]
    public class PaymentDeniedException: BaseException
    {
        public PaymentDeniedException(): base("002", "Payment Denied") { }
    }
}
