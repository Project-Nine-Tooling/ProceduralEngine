using ProceduralEngine.Entities;
using System.Diagnostics;
using System.Reflection;

namespace ProceduralEngine.IO
{
    public sealed class ObjExporter
    {
        #region Construction
        public ObjExporter(Geometry geometry)
        {
            Geometry = geometry;
        }
        #endregion

        #region Properties
        public Geometry Geometry { get; }
        #endregion

        #region Methods
        public void Export(string path)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string version = (!string.IsNullOrEmpty(assemblyLocation) && File.Exists(assemblyLocation)) ? FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion : null;
            string versionString = string.IsNullOrEmpty(version) ? string.Empty : $"v{version}";

            File.WriteAllText(path, $"""
                # Procedural Engine {versionString}
                """);
        }
        #endregion
    }
}
