using UnityEngine;

public class WinBehaviour : MonoBehaviour
{
    public GameObject winPanel;

    void Start()
    {
        winPanel.SetActive(false);
    }

    public void CheckGameWin()
    {
        if (transform.childCount <= 1)
        {
            GameWon();
        }
    }

    void GameWon()
    {
        Time.timeScale = 0;
        winPanel.SetActive(true);
    }
}
