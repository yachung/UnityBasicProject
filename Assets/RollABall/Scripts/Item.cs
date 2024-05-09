using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace RollABall
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;

        private void Awake()
        {
            // GameManager ������Ʈ�� ���� ���� ������Ʈ�� �˻�.
            // FindFirst ���� �޼ҵ�� �˻��� �ϰ� ù��°�� ã������ �ű⼭ ����.
            gameManager = FindFirstObjectByType<GameManager>();
        }

        private void OnDestroy()
        {
            gameManager.AddScore();    
        }
    }
}