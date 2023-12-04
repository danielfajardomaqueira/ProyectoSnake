using TMPro;
using UnityEngine;


public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;
    public void UpdateScoreText(int score)
    {
        scoreText.text = score.ToString();

        int highScore = Score.GetHighScore();
        highScoreText.text = highScore.ToString();
    }

    private void Awake()
    {
        // Singleton
        if (Instance != null)
        {
            Debug.LogError("There is more than one Instance");
        }

        Instance = this;
    }
}
