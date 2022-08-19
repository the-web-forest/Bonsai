using System;
using System.Runtime.Serialization;

namespace Bonsai.Domain.Errors
{
    [Serializable]
    public abstract class BaseException: Exception
    {

        protected BaseException()
        {
        }

        protected BaseException(string Code, string Message) : base(Message)
        {
            Data.Add("Code", "BON-"+Code);
            Data.Add("Message", Message);
            Data.Add("ShortMessage", Message.Replace(" ", string.Empty));
        }

        protected BaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

    }
}
