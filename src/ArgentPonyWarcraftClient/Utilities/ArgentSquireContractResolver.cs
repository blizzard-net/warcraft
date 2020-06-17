using System;
using Newtonsoft.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A custom contract resolver for use with Json.NET.
    /// </summary>
    internal class ArgentPonyWarcraftClientContractResolver : DefaultContractResolver
    {
        /// <summary>
        ///     Determines which contract type is created for the given type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>A <see cref="JsonContract" /> for the given type.</returns>
        protected override JsonContract CreateContract(Type objectType)
        {
            if (objectType == typeof(DateTime) || objectType == typeof(DateTime?))
            {
                JsonContract contract = base.CreateObjectContract(objectType);
                contract.Converter = new JsonEpochConverter();
                return contract;
            }

            return base.CreateContract(objectType);
        }
    }
}
