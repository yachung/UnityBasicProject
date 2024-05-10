using System;
using UnityEngine;

[ExecuteInEditMode]
public class CustomMeshCube : MonoBehaviour
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

        // 0, 0, 0 정육면체의 중앙
        Vector3[] vertices = new Vector3[]
        {
            // xy 평면으로 대칭
            // 0, 0, -0.5 back
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),

            // 0, 0, 0.5 front
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),

            // yz 평면으로 대칭
            // -0.5, 0, 0 left
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f, -0.5f),

            // 0.5, 0, 0 right 
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),

            // xz 평면으로 대칭
            // 0, -0.5, 0 bottom
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f,  0.5f),
            new Vector3( 0.5f, -0.5f, -0.5f),

            // 0, 0.5, 0 top
            new Vector3(-0.5f,  0.5f, -0.5f),
            new Vector3(-0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f,  0.5f),
            new Vector3( 0.5f,  0.5f, -0.5f),
                            //    0    0 -0.5 back
                            //    0    0  0.5 front
                            // -0.5    0    0 left
                            //  0.5    0    0 right
                            //    0 -0.5    0 bottom
                            //    0  0.5    0 top
        };

        int[] indices = new int[]
        {   0, 1, 2,
            0, 2, 3,
            4, 5, 6,
            4, 6, 7,
            8, 9, 10,
            8, 10, 11,
            12, 14, 13,
            12, 15, 14,
            16, 18, 17,
            16, 19, 18,
            20, 21, 22,
            20, 22, 23
        };

        Vector3[] normals = new Vector3[]
        {
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),

                new Vector3 (0f, 0f,  1f),
                new Vector3 (0f, 0f,  1f),
                new Vector3 (0f, 0f,  1f),
                new Vector3 (0f, 0f,  1f),

                new Vector3 (-1f, 0f, 0f),
                new Vector3 (-1f, 0f, 0f),
                new Vector3 (-1f, 0f, 0f),
                new Vector3 (-1f, 0f, 0f),

                new Vector3 (1f,  0f,  0f),
                new Vector3 (1f,  0f,  0f),
                new Vector3 (1f,  0f,  0f),
                new Vector3 (1f,  0f,  0f),

                new Vector3 (0f, -1f,  0f),
                new Vector3 (0f, -1f,  0f),
                new Vector3 (0f, -1f,  0f),
                new Vector3 (0f, -1f,  0f),

                new Vector3 (0f,  1f,  0f),
                new Vector3 (0f,  1f,  0f),
                new Vector3 (0f,  1f,  0f),
                new Vector3 (0f,  1f,  0f),
        };


        Vector3[] uvs = new Vector3[]
        {
            // 0, 0, -0.5 back
            new Vector3(-1f, -1f, 0f),
            new Vector3(-1f,  0f, 0f),
            new Vector3( 0f,  0f, 0f),
            new Vector3( 0f, -1f, 0f),

            // 0, 0, 0.5 front
            new Vector3(-1f, -1f,  0f),
            new Vector3(-1f,  0f,  0f),
            new Vector3( 0f,  0f,  0f),
            new Vector3( 0f, -1f,  0f),

            // -0.5, 0, 0 left
            new Vector3(-1f, -1f, 0f),
            new Vector3(-1f,  0f, 0f),
            new Vector3( 0f,  0f, 0f),
            new Vector3( 0f, -1f, 0f),

            new Vector3(-1f, -1f, 0f),
            new Vector3(-1f,  0f, 0f),
            new Vector3( 0f,  0f, 0f),
            new Vector3( 0f, -1f, 0f),

            new Vector3(-1f, -1f, 0f),
            new Vector3(-1f,  0f, 0f),
            new Vector3( 0f,  0f, 0f),
            new Vector3( 0f, -1f, 0f),

            new Vector3(-1f, -1f, 0f),
            new Vector3(-1f,  0f, 0f),
            new Vector3( 0f,  0f, 0f),
            new Vector3( 0f, -1f, 0f),
            //// 0.5, 0, 0 right 
            //new Vector3( 0.5f, -0.5f,  0.5f),
            //new Vector3( 0.5f,  0.5f,  0.5f),
            //new Vector3( 0.5f,  0.5f, -0.5f),
            //new Vector3( 0.5f, -0.5f, -0.5f),

            //// 0, -0.5, 0 bottom
            //new Vector3(-0.5f, -0.5f, -0.5f),
            //new Vector3(-0.5f, -0.5f,  0.5f),
            //new Vector3( 0.5f, -0.5f,  0.5f),
            //new Vector3( 0.5f, -0.5f, -0.5f),

            //// 0, 0.5, 0 top
            //new Vector3(-0.5f,  0.5f, -0.5f),
            //new Vector3(-0.5f,  0.5f,  0.5f),
            //new Vector3( 0.5f,  0.5f,  0.5f),
            //new Vector3( 0.5f,  0.5f, -0.5f),
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
