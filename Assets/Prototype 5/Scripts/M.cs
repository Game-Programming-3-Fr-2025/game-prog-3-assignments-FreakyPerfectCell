using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace PrototypeFour
{
    public class M : MonoBehaviour
    {

        public static M Instance;
        public int score = 0;
        public Text scoreText;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void AddScore(int amount)
        {
            score += amount;
            UpdateScoreUI();
        }

        private void UpdateScoreUI()
        {
            if (scoreText != null)
            {
                scoreText.text = "Loops: " + score;
            }
        }
    }
}
