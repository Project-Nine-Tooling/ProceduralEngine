using ProceduralEngine.IO;

namespace ProceduralEngine.Entities
{
    public abstract class Geometry
    {
        #region Operations
        public Geometry Bevel()
        {
            return this;
        }
        public Geometry Extrude()
        {
            return this;
        }
        #endregion

        #region IO
        public Geometry Export(string path)
        {
            string fullPath = Path.GetFullPath(path);
            new ObjExporter(this).Export(path);
            return this;
        }
        #endregion
    }
}
