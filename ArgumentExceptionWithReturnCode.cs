using System.Runtime.Serialization;

namespace de.mydevtime.Exceptions;

public class ArgumentExceptionWithReturnCode : ArgumentException
{
    /// <summary>
    /// Gets the return code associated with this exception.
    /// </summary>
    public int ReturnCode { get; }

    public ArgumentExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected ArgumentExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public ArgumentExceptionWithReturnCode(string? paramName, int returnCode) : base(paramName)
    {
        ReturnCode = returnCode;
    }

    public ArgumentExceptionWithReturnCode(string? message, Exception? innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }

    public ArgumentExceptionWithReturnCode(string? paramName, string? message, int returnCode) : base(paramName, message)
    {
        ReturnCode = returnCode;
    }
}