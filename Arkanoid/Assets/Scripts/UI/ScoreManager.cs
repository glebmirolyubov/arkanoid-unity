using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public Text scoreText, looseScoreText, winScoreText;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        looseScoreText.text = score.ToString();
        winScoreText.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        looseScoreText.text = score.ToString();
        winScoreText.text = score.ToString();
    }
}
