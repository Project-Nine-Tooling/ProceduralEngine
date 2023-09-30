Import(ProceduralEngine)
using static ProceduralEngine.Tools.CreationNodes;
using Vector = ProceduralEngine.Types.Vector;

Create("Cube")
    .Bevel(2)
    .Export("BeveledCube.obj");