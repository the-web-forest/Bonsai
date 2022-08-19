using System;
using System.Runtime.Serialization;

namespace Bonsai.Domain.Errors
{
    [Serializable]
    public abstract class BaseException: Exception
    {

        public BaseException()
        {
        }

        public BaseException(string Code, string Message) : base(Message)
        {
            Data.Add("Code", "BON-"+Code);
            Data.Add("Message", Message);
            Data.Add("ShortMessage", Message.Replace(" ", string.Empty));
        }

        public BaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

    }
}
