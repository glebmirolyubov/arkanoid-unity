using UnityEngine;
using UnityEngine.UI;

public class BlockTimerMovement : MonoBehaviour
{
    public Text timerValue;

    float timerAmount = 15.0f;

    void Update()
    {
        timerAmount -= Time.deltaTime;  
        timerValue.text = timerAmount.ToString("F0") + "s";

        if (timerAmount <= 0f)
        {
            MoveBlocksDown();
        }
    }

    void MoveBlocksDown()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
        timerAmount = 15.0f;
    }
}
