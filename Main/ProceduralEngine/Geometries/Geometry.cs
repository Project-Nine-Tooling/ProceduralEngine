namespace ProceduralEngine.Entities
{
    public abstract class Geometry
    {
        #region Operations
        public Geometry Bevel()
        {
            return this;
        }
        #endregion

        #region IO
        public Geometry Export(string path)
        {
            string fullPath = Path.GetFullPath(path);
            return this;
        }
        #endregion
    }
}
