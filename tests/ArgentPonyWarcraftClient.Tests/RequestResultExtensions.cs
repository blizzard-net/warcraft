namespace ArgentPonyWarcraftClient.Tests
{
    public static class RequestResultExtensions
    {
        /// <summary>
        /// Returns a <see cref="RequestResultAssertions{T}"/> object that can be used to
        /// assert the current <see cref="RequestResult{T}"/>.
        /// </summary>
        /// <param name="subject">
        /// The current <see cref="RequestResult{T}"/> instance.
        /// </param>
        /// <typeparam name="T"></typeparam>
        /// <returns>
        /// A <see cref="RequestResultAssertions{T}"/> object..
        /// </returns>
        public static RequestResultAssertions<T> Should<T>(this RequestResult<T> subject) =>
            new RequestResultAssertions<T>(subject);
    }
}
