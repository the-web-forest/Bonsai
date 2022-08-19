using System;

namespace Bonsai.Domain.Errors
{
    [Serializable]
    public abstract class BaseException: Exception
    {
        protected BaseException(string Code, string Message) : base(Message)
        {
            Data.Add("Code", "BON-"+Code);
            Data.Add("Message", Message);
            Data.Add("ShortMessage", Message.Replace(" ", string.Empty));
        }

    }
}
