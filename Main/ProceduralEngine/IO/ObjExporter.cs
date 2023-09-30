using System.Diagnostics;
using System.Reflection;

namespace ProceduralEngine.IO
{
    public sealed class ObjExporter
    {
        public void Export(string path)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string version = (!string.IsNullOrEmpty(assemblyLocation) && File.Exists(assemblyLocation)) ? FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion : null;
            string versionString = string.IsNullOrEmpty(version) ? string.Empty : $"v{version}";

            File.WriteAllText(path, $"""
                # Procedural Engine {versionString}
                """);
        }
    }
}
