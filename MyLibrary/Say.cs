using System;

namespace MyLibrary
{
    public class Say
    {
        public string Hello()
        {
#if NET461
            return "Target framework: .NET Framework 4.6.1";
#elif NET471
            return "Target framework: .NET Framework 4.7.1";
#elif NETCOREAPP2_0
            return "Target framework: .NET Core 2.0";
#elif NETSTANDARD2_0
            return "Target framework: .NET Standard 2.0";
#else
            return "Can't find Target framework";
#endif
        }
    }
}
