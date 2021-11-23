using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FOV_Camera : MonoBehaviour
{

    public Camera cam;
    public GameObject CCTV;
    public Material SuperGlass;

    void Start()
    {
        //cam = GetComponent<Camera>(); //finds camera on this object
        GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube); //makes a cube
        g.GetComponent<Renderer>().material = SuperGlass;
        Destroy(g.GetComponent<BoxCollider>()); //destroy the box collider on the cube because it's not needed
        MeshFilter meshFilter = g.GetComponent<MeshFilter>(); //get the meshfilter on cube
                                                              //make a new mesh
        Mesh mesh = new Mesh();
        Vector3[] points = new Vector3[5];
        points[0] = cam.transform.position;
        points[1] = cam.ViewportToWorldPoint(new Vector3(0, 0, cam.farClipPlane));
        points[2] = cam.ViewportToWorldPoint(new Vector3(0, 1, cam.farClipPlane));
        points[3] = cam.ViewportToWorldPoint(new Vector3(1, 0, cam.farClipPlane));
        points[4] = cam.ViewportToWorldPoint(new Vector3(1, 1, cam.farClipPlane));
        mesh.vertices = new Vector3[] {
        points[0], points[1], points[2],
        points[0], points[3], points[1],
        points[0], points[4], points[2],
        points[0], points[3], points[4],
        points[1], points[2], points[4],
        points[1], points[4], points[3]
    };

        mesh.triangles = new int[] {
        0, 1, 2,
        3, 4, 5,
        8, 7, 6,
        11, 10, 9,
        14, 13, 12,
        17, 16, 15
    };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.MarkDynamic();
        //set the new mesh to cube's mesh
        meshFilter.mesh = mesh;
        //set the camera as the cube's parent
        g.transform.SetParent(cam.transform);
    }

}
