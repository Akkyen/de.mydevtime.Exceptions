using System.Runtime.Serialization;

namespace de.mydevtime.Exceptions;

public class InvalidOperationExceptionWithReturnCode : InvalidOperationException
{
    public int ReturnCode { get; }

    public InvalidOperationExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected InvalidOperationExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public InvalidOperationExceptionWithReturnCode(string? message, int returnCode) : base(message)
    {
        ReturnCode = returnCode;
    }

    public InvalidOperationExceptionWithReturnCode(string? message, Exception? innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }
}