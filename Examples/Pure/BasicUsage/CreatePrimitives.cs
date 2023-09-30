Import(ProceduralEngine)
using static ProceduralEngine.Tools.CreationNodes;
using Vector = ProceduralEngine.Types.Vector;

// Style 1
var cube = CreateCube();
cube.Export("Cube.obj");

// Style 2
Create("Sphere")
    .Export("Sphere.obj");