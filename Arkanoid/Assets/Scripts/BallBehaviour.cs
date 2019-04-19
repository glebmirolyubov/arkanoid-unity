using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private Vector2 ballInitialForce;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        ballInitialForce = new Vector2(120.0f, 320.0f);
    }

    public void LaunchBall()
    {
        rb2D.AddForce(ballInitialForce);
    }
}
