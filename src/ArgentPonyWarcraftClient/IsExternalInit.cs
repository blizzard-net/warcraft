#if NETSTANDARD2_0

namespace System.Runtime.CompilerServices;

// This is required to enable the init keyword while targeting lower than .NET 5
// See https://stackoverflow.com/a/64749403/342581.
internal static class IsExternalInit { }

#endif
