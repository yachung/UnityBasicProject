using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace RollABall
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;

        private void Awake()
        {
            // GameManager 컴포넌트를 가진 게임 오브젝트를 검색.
            // FindFirst 류의 메소드는 검색을 하고 첫번째로 찾았으면 거기서 멈춤.
            gameManager = FindFirstObjectByType<GameManager>();
        }

        private void OnDestroy()
        {
            gameManager.AddScore();    
        }
    }
}