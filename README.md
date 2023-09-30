# ProceduralEngine

Spiritual successor of [The Matrix](https://github.com/Charles-Zhang-Project-Nine/TheMatrix) project (also see [TheMatrixSoftwareComponents](https://github.com/Charles-Zhang-Project-Nine/TheMatrixSoftwareComponents)), dedicated to just geometry generations. This will replace our use/need for Houdini or Blender Geometry nodes for procedural mesh generations. In time, the hope is this will become our go-to scripting solution for primitive generations which will allow greater scripting flexibility and efficiency, paywall-freedom, and data-driven design. See P9's treatment note on the subject.

This is dedicated to Project Nine, but this library will be a generic and non-project nine specific tool.

Key ideas:

1. Polygon-based
2. Point and Primitive structure
3. Raw C#, zero dependancies (except Math.Net)
4. Pure ready
5. Double-point precision, no inherent numerical limits

The main usage of this library can be divided into three levels:

1. Raw algorithms and routines: For importing/exporting/converting, and other meta-use of existing functionalities;
2. Operations: For low-level primitive-level operations on entities;
3. Nodes: Like Blender/Houdini, we will provide a set of "nodes" as meta-structures for higher level constructions; Unlike Houdini/TerraGen, those nodes will not share any global state, and like Blender, those nodes will have explicit input and output and parameter types.
4. Graphs: Assembles of Nodes.

See documentation for [main library (ProceduralEngine)](./Main/ProceduralEngine) for more details.

## Concepts

The system uses Blender-like coordinate system, i.e. Z Up, X Forward (facing viewer), Y Right, with a right-handed coordinate system.

Following the well-established practice of Blender Geometry Nodes and Houdini, the most fundamental operational unit is "points", and on top of it we have "primitives", which is capable of representing both 