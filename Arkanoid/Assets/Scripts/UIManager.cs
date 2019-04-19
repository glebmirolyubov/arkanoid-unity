using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public BallBehaviour ballBehaviour;
    public GameObject startPanel;

    void Start()
    {
        Time.timeScale = 0;
        startPanel.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        ballBehaviour.LaunchBall();
        startPanel.SetActive(false);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
