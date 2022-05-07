using UnityEngine;
public class Camera : MonoBehaviour
{
    public static float X = 0;
    public static float Y = -90;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && X > -60) X-= .1f;
        if (Input.GetKey(KeyCode.DownArrow) && X < 0) X += .1f;

        if (Input.GetKey(KeyCode.RightArrow) && Y < -55) Y += .1f;
        if (Input.GetKey(KeyCode.LeftArrow) && Y > -125) Y -= .1f;

        transform.localRotation = Quaternion.Euler(X, Y, 0);
    }
}
