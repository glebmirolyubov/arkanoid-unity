using UnityEngine;

public class WallBoundariesBehaviour : MonoBehaviour
{
    public GameObject topWall, leftWall, rightWall;

    Vector2 leftBorder, rightBorder, topBorder;

    void Start()
    {
        topBorder = Camera.main.ViewportToWorldPoint(new Vector2(0.5f, 1f));
        leftBorder = Camera.main.ViewportToWorldPoint(new Vector2(0, 0.5f));
        rightBorder = Camera.main.ViewportToWorldPoint(new Vector2(1, 0.5f));

        AdjustWallsWithScreenSize();
    }

    void AdjustWallsWithScreenSize ()
    {
        topWall.transform.position = topBorder;
        leftWall.transform.position = leftBorder;
        rightWall.transform.position = rightBorder;
    }
}