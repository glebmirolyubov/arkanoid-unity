using UnityEngine;

public class DefeatBehaviour : MonoBehaviour
{
    public GameObject defeatPanel;

    void Start()
    {
        defeatPanel.SetActive(false);
    }

    void GameOver()
    {
        Time.timeScale = 0;
        defeatPanel.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "BlocksSpawnArea")
        {
            GameOver();
        }
    }
}
