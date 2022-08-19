namespace Bonsai.Domain.Errors
{
    [Serializable]
    public class PaymentDeniedException: BaseException
    {
        protected PaymentDeniedException(): base("002", "Payment Denied") { }
    }
}
