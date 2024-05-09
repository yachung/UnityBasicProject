using UnityEngine;

namespace CustomMesh
{
    [ExecuteInEditMode]
    public class CustomMesh : MonoBehaviour
    {
        // MeshFilter ������Ʈ
        // Mesh �����͸� ������.
        [SerializeField] private MeshFilter meshFilter;
        
        // MeshRenderer ������Ʈ
        // Material�� ����� Mesh�� �׸��� ĥ��.
        [SerializeField] private MeshRenderer meshRenderer;

        private void Awake()
        {
            // �ϴ� �ִ��� �˻� �� ����
            meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null ) meshFilter = gameObject.AddComponent<MeshFilter>();

            meshRenderer = GetComponent<MeshRenderer>();
            if ( meshRenderer == null ) meshRenderer = gameObject.AddComponent<MeshRenderer>();

            // �޽� ����.
            Mesh mesh = new Mesh();

            Vector3[] vertices = new Vector3[]
            {
                // ���� ��ġ.
                new Vector3(-0.5f, 0.5f, 0),
                new Vector3(0.5f, 0.5f, 0),
                new Vector3(-0.5f, -0.5f, 0),
                new Vector3(0.5f, -0.5f, 0)
            };

            // �޽ÿ� ���� ����.
            mesh.SetVertices(vertices);

            // ������ �ִµ� ������ �ִ� ������� �迭�� �־������.
            int[] indices = new int[] { 0, 1, 2, 2, 1, 3 };

            // �޽ÿ� �ε��� ����
            // �ε��� �迭, ���� ���� ���, ���� �޽� �ε���
            mesh.SetIndices(indices, MeshTopology.Triangles, 0);

            // ���(����) �߰�
            Vector3[] normals = new Vector3[]
            {
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f),
                new Vector3 (0f, 0f, -1f)
            };

            // �޽ÿ� ��� ����.
            mesh.SetNormals(normals);

            // uv ����
            Vector2[] uvs = new Vector2[]
            {
                new Vector2(0f, 1f),
                new Vector2(1f, 1f),
                new Vector2(0f, 0f),
                new Vector2(1f, 0f)
            };

            // uv ����
            mesh.SetUVs(0, uvs);

            meshFilter.mesh = mesh;
        }
    }
}
