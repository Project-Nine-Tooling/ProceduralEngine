Import(ProceduralEngine)

CreateScene()
    .Add(CreateCube("My Cube", new Vector(1, 0, 0)))
    .Add(CreateSphere("My Sphere", new Vector(0, 0, 0)))
    .Export("Scene.obj");