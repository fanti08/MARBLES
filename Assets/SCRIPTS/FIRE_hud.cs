using UnityEngine;
using UnityEngine.UI;

public class FIRE_hud : MonoBehaviour
{
    int mode;
    int power;

    private void Update()
    {
        HUD();

        Shoot();
    }

    #region HUD

    public Transform sel_1;
    public Transform sel_2;
    public Text rotationx;
    public Text rotationy;

    private void HUD()
    {
        //type
        if (Input.GetKeyDown(KeyCode.B))
        {
            mode = 1;
            sel_1.localPosition = new Vector3(-310, 208, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            mode = 2;
            sel_1.localPosition = new Vector3(-310, 185, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            mode = 3;
            sel_1.localPosition = new Vector3(-310, 162, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            mode = 4;
            sel_1.localPosition = new Vector3(-310, 139, 0);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            mode = 5;
            sel_1.localPosition = new Vector3(-310, 116, 0);
        }
        if (Input.GetKeyDown(KeyCode.Question))
        {
            mode = 6;
            sel_1.localPosition = new Vector3(-310, 93, 0);
        }

        //strenght
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            power = 1;
            sel_2.localPosition = new Vector3(-212, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            power = 2;
            sel_2.localPosition = new Vector3(-190, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            power = 3;
            sel_2.localPosition = new Vector3(-168, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            power = 4;
            sel_2.localPosition = new Vector3(-212, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            power = 5;
            sel_2.localPosition = new Vector3(-190, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            power = 6;
            sel_2.localPosition = new Vector3(-168, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            power = 7;
            sel_2.localPosition = new Vector3(-212, 115, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            power = 8;
            sel_2.localPosition = new Vector3(-190, 115, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            power = 9;
            sel_2.localPosition = new Vector3(-168, 115, 0);
        }

        //direction
        int X = -Mathf.RoundToInt(Camera.X);
        int Y = Mathf.RoundToInt(Camera.Y) + 90;
        rotationx.text = "rotation x = " + X + "°";
        rotationy.text = "rotation y = " + Y + "°";
    }

    #endregion HUD

    #region Shoot

    private void Shoot()
    {
        
    }

    #endregion Shoot
}
