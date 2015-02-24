﻿module primitives
open OpenTK

type mesh = { 
        vertices : Vector3d []
        indices : int []
    }
    with
    member this.verticesSize = this.vertices.Length * sizeof<Vector3>

let unitCube = { 
        vertices = 
            [| 
                new Vector3d(-0.5, -0.5, -0.5) //back
                new Vector3d(0.5, -0.5, -0.5)
                new Vector3d(0.5, 0.5, -0.5)
                new Vector3d(-0.5, 0.5, -0.5)
                new Vector3d(-0.5, -0.5, 0.5) //front
                new Vector3d(0.5, -0.5, 0.5)
                new Vector3d(0.5, 0.5, 0.5)
                new Vector3d(-0.5, 0.5, 0.5)
            |]
        indices = 
            [| 
                4; 6; 7; //front
                4; 5; 6;
                6; 5; 1; //right
                6; 1; 2;
                0; 4; 7; //left
                0; 7; 3;
                0; 2; 1; //back
                0; 3; 2;
                7; 6; 2; //top
                7; 2; 3;
                4; 1; 5; //bottom
                4; 0; 1;
            |] 
    }