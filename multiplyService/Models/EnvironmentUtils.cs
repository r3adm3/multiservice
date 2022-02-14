using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace multiservice.Models
{

    public static class EnvironmentUtils
    {
        /// <summary>
        /// Return correct .NET Core product name like ".NET Core 2.1.0" instead of ".NET Core 4.6.26515.07" returning by RuntimeInformation.FrameworkDescription
        /// </summary>
        /// <returns></returns>
        public static string GetFrameworkDescription()
        {
            // ".NET Core 4.6.26515.07" => ".NET Core 2.1.0"
            var parts = RuntimeInformation.FrameworkDescription.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var i = 0;
            for(; i < parts.Length; i++)
            {
                if (Char.IsDigit(parts[i][0]))
                {
                    break;
                }
            }
            var productName = String.Join(' ', parts, 0, i);
            return String.Join(' ', productName, " ", GetNetCoreVersion());
        }

        public static string GetNetCoreVersion()
        {
            var assembly = typeof(System.Runtime.GCSettings).GetTypeInfo().Assembly;
            var assemblyPath2 = assembly.Location.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);

            int netCoreAppIndex = Array.IndexOf(assemblyPath2, "Microsoft.NETCore.App");
            if (netCoreAppIndex > 0 && netCoreAppIndex < assemblyPath2.Length - 2)
                return assemblyPath2[netCoreAppIndex + 1];
            return null;
        }

    }
}