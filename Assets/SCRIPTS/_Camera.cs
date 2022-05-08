using UnityEngine;

public class _Camera : MonoBehaviour
{
    public static float X;
    public static float Y;

    private void Start()
    {
        X = 0;
        Y = -90;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && X > -60) X-= 1;
        if (Input.GetKeyDown(KeyCode.DownArrow) && X < 0) X += 1;

        if (Input.GetKeyDown(KeyCode.RightArrow) && Y < -55) Y += 1;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Y > -125) Y -= 1;

        transform.localRotation = Quaternion.Euler(X, Y, 0);
    }
}
