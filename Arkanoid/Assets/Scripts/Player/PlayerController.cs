using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 10.0f;

    Vector3 leftBorder, rightBorder;

    void Start()
    {
        leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5f, 0));
        rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0.5f, 0));
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;

        transform.Translate(movement * Vector2.right);

        if (transform.position.x < leftBorder.x) {
            transform.position = new Vector2 (leftBorder.x, transform.position.y);
        } else if (transform.position.x > rightBorder.x)
        {
            transform.position = new Vector2(rightBorder.x, transform.position.y);
        }
    }
}