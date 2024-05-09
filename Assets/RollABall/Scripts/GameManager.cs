using UnityEngine;

namespace RollABall
{
    public class GameManager : MonoBehaviour
    {
        // 점수
        [SerializeField] private int score = 0;
        
        // 목표 점수
        // 씬에 배치된 Item의 개수.
        [SerializeField] private int targetScore = 0;

        // 점수를 보여줄 TextUI
        [SerializeField] private TMPro.TextMeshProUGUI scoreText;
        [SerializeField] private TMPro.TextMeshProUGUI clearText;

        private void Awake()
        {
            // 검색 -> 아이템이 몇 개인지
            // 게임오브젝트를 검색하는데 태그를 조건으로 할 수 있나?
            targetScore = GameObject.FindGameObjectsWithTag("Item").Length;
        }

        // 점수 획득 메소드
        public void AddScore()
        {
            score += 1;

            scoreText.text = $"Score: {score}";

            if (IsGameClear())
            {
                clearText.gameObject.SetActive(true);
                Debug.LogWarning("GameClear");
            }
        }

        // 게임 클리어 확인
        private bool IsGameClear()
        {
            // 예외처리.
            return score == targetScore;
        }
    }
}