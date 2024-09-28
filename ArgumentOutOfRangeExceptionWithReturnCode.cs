using System.Runtime.Serialization;

namespace de.mydevtime.Exceptions;

public class ArgumentOutOfRangeExceptionWithReturnCode : ArgumentOutOfRangeException
{
    /// <summary>
    /// Gets the return code associated with this exception.
    /// </summary>
    public int ReturnCode { get; }

    public ArgumentOutOfRangeExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected ArgumentOutOfRangeExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public ArgumentOutOfRangeExceptionWithReturnCode(string? paramName, int returnCode) : base(paramName)
    {
        ReturnCode = returnCode;
    }

    public ArgumentOutOfRangeExceptionWithReturnCode(string? message, Exception? innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }

    public ArgumentOutOfRangeExceptionWithReturnCode(string? paramName, object? actualValue, string? message, int returnCode) : base(paramName, actualValue, message)
    {
        ReturnCode = returnCode;
    }

    public ArgumentOutOfRangeExceptionWithReturnCode(string? paramName, string? message, int returnCode) : base(paramName, message)
    {
        ReturnCode = returnCode;
    }
}