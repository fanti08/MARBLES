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
        if (Input.GetKey(KeyCode.UpArrow) && X > -60) X-= .02f;
        if (Input.GetKey(KeyCode.DownArrow) && X < 0) X += .02f;

        if (Input.GetKey(KeyCode.RightArrow) && Y < -55) Y += .02f;
        if (Input.GetKey(KeyCode.LeftArrow) && Y > -125) Y -= .02f;

        transform.localRotation = Quaternion.Euler(X, Y, 0);
    }
}
