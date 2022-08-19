using System.Runtime.Serialization;

namespace Bonsai.Domain.Errors
{
    [Serializable]
    public class UnauthorizedException: BaseException
    {
        public UnauthorizedException(): base("001", "Unauthorized") { }
        protected UnauthorizedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
