using System;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    [SerializeField]
    MeshFilter meshFilter;
    [SerializeField]
    MeshRenderer meshRenderer;

    private void Awake()
    {
        InitializeComponent();
        SetMesh();
    }

    private void SetMesh()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[]
        {
            
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),

            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),

            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),

            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),

            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),

                            //    0    0 -0.5 back
                            //    0    0  0.5 front
                            //  0.5    0    0 right
                            // -0.5    0    0 left
                            //    0  0.5    0 top
                            //    0 -0.5    0 bottom
        };

        int[] indices = new int[] 
        {   0, 1, 2, 
            0, 2, 3,
            4, 5, 6,
            4, 6, 7
        };


        Vector3[] normals = new Vector3[]
        {
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f)
        };


        Vector2[] uvs = new Vector2[]
        {
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(0f, 0f),
                new Vector2(1f, 0f)
        };

        mesh.SetVertices(vertices);
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);
        mesh.SetNormals(normals);
        mesh.SetUVs(0, uvs);

        meshFilter.mesh = mesh;

    }

    private void InitializeComponent()
    {
        // 일단 있는지 검색 후 설정
        meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null) meshFilter = gameObject.AddComponent<MeshFilter>();

        meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null) meshRenderer = gameObject.AddComponent<MeshRenderer>();
    }

}
