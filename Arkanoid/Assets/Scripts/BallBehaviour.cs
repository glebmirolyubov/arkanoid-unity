using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;

    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        // create the force
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // set to inactive
        ballIsActive = false;

        // ball position
        ballPosition = transform.position;
    }

    void Update()
    {
        // check for user input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // check if is the first play
            if (!ballIsActive)
            {
                // add a force
                rb2D.AddForce(ballInitialForce);
                // set ball active
                ballIsActive = !ballIsActive;
            }
        }
    }
}
