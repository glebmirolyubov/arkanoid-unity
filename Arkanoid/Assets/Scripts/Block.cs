using UnityEngine;

public class Block : MonoBehaviour
{
    private WinBehaviour winBehaviour;
    private ScoreManager scoreManager;
    private SpriteRenderer spriteRenderer;

    int blockHealth;

    void Awake()
    {
        winBehaviour = GameObject.FindWithTag("BlocksSpawnArea").GetComponent<WinBehaviour>();
        scoreManager = GameObject.FindWithTag("Player").GetComponent<ScoreManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void InitializeBlock (int blockHealth)
    {
        switch (blockHealth)
        {
            case 1:
                this.blockHealth = 1;
                spriteRenderer.color = Color.gray;
                break;
            case 2:
                this.blockHealth = 2;
                spriteRenderer.color = Color.green;
                break;
            case 3:
                this.blockHealth = 3;
                spriteRenderer.color = Color.yellow;
                break;
            default:
                this.blockHealth = 1;
                spriteRenderer.color = Color.gray;
                break;
        }
    }

    void BlockDestructionProgress()
    {
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, spriteRenderer.color.a - 0.3f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            blockHealth--;
            scoreManager.IncreaseScore();
            BlockDestructionProgress();

            if (blockHealth <= 0)
            {
                scoreManager.IncreaseScore();
                winBehaviour.CheckGameWin();
                Destroy(gameObject);
            }
        }
    }
}