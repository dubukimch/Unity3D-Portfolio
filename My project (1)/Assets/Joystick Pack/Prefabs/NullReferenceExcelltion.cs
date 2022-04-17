using System;
using System.Runtime.Serialization;

[Serializable]
internal class NullReferenceExcelltion : Exception
{
    public NullReferenceExcelltion()
    {
    }

    public NullReferenceExcelltion(string message) : base(message)
    {
    }

    public NullReferenceExcelltion(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected NullReferenceExcelltion(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}