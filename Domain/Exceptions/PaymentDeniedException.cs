using System.Runtime.Serialization;

namespace Bonsai.Domain.Errors
{
    [Serializable]
    public class PaymentDeniedException: BaseException
    {
        public PaymentDeniedException(): base("002", "Payment Denied") { }
        protected PaymentDeniedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
