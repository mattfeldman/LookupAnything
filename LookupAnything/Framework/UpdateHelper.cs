using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using Version = StardewModdingAPI.Version;

namespace Pathoschild.LookupAnything.Framework
{
    /// <summary>Provides utility methods for mod updates.</summary>
    internal class UpdateHelper
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Get a semantic version number from the given version data.</summary>
        /// <param name="version">The version data.</param>
        public static string GetSemanticVersion(Version version)
        {
            return version.PatchVersion != 0
                ? $"{version.MajorVersion}.{version.MinorVersion}.{version.PatchVersion}"
                : $"{version.MajorVersion}.{version.MinorVersion}";
        }

        /// <summary>Get the latest release in a GitHub repository.</summary>
        /// <param name="repository">The name of the repository from which to fetch releases (like "pathoschild/LookupAnything").</param>
        public static GitRelease GetLatestRelease(string repository)
        {
            using (WebClient client = new WebClient())
            {
                // add user agent
                AssemblyName assembly = typeof(UpdateHelper).Assembly.GetName();
                client.Headers.Add(HttpRequestHeader.UserAgent, $"{assembly.Name}/{assembly.Version}");

                // add API version
                client.Headers.Add(HttpRequestHeader.Accept, "application/vnd.github.v3+json");

                // fetch data
                string response = client.DownloadString($"https://api.github.com/repos/{repository}/releases/latest");
                return JsonConvert.DeserializeObject<GitRelease>(response);
            }
        }
    }
}
