namespace ArgentPonyWarcraftClient;

/// <summary>
///     Represents a request made to the Blizzard API.
/// </summary>
/// <typeparam name="TValue"></typeparam>
public record RequestResult<TValue>
{
    /// <summary>
    ///    The requested object value from the Blizzard API.
    /// </summary>
    public TValue Value { get; }

    /// <summary>
    ///     The request error response from the Blizzard API.
    /// </summary>
    public RequestError Error { get; }

    /// <summary>
    ///     Indicates if the HTTP request succeeded.
    /// </summary>
    public bool Success { get; }

    /// <summary>
    ///     Initializes a request result with an object value.
    /// </summary>
    public RequestResult(TValue value)
    {
        Value = value;
        Success = true;
    }

    /// <summary>
    ///     Initializes a request result with an error.
    /// </summary>
    public RequestResult(RequestError error)
    {
        Error = error ?? throw new ArgumentNullException(nameof(error));
        Success = false;
    }

    /// <summary>
    ///     Implicit operator for initializing an object result with a value.
    /// </summary>
    public static implicit operator RequestResult<TValue>(TValue value)
    {
        return new RequestResult<TValue>(value);
    }

    /// <summary>
    ///     Implicit operator for initializing an object result with an error.
    /// </summary>
    /// <param name="error"></param>
    public static implicit operator RequestResult<TValue>(RequestError error)
    {
        return new RequestResult<TValue>(error);
    }
}
