using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void LaunchBall()
    {
        rb2D.velocity = new Vector2(2, 7);
    }
}
