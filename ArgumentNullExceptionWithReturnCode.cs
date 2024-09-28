using System.Runtime.Serialization;

namespace de.mydevtime.Exceptions;

public class ArgumentNullExceptionWithReturnCode : ArgumentNullException
{
    /// <summary>
    /// Gets the return code associated with this exception.
    /// </summary>
    public int ReturnCode { get; }

    public ArgumentNullExceptionWithReturnCode(int returnCode)
    {
        ReturnCode = returnCode;
    }

    [Obsolete("Obsolete")]
    protected ArgumentNullExceptionWithReturnCode(SerializationInfo info, StreamingContext context, int returnCode) : base(info, context)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string? paramName, int returnCode) : base(paramName)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string? message, Exception? innerException, int returnCode) : base(message, innerException)
    {
        ReturnCode = returnCode;
    }

    public ArgumentNullExceptionWithReturnCode(string? paramName, string? message, int returnCode) : base(paramName, message)
    {
        ReturnCode = returnCode;
    }
}