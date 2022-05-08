using UnityEngine;
using UnityEngine.UI;

public class FIRE_hud : MonoBehaviour
{
    public static int mode;
    public static float power;

    private void Start()
    {
        mode = 1;
        power = 3.8f;
    }

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
        if (Input.GetKeyDown(KeyCode.M))
        {
            mode = 6;
            sel_1.localPosition = new Vector3(-310, 93, 0);
        }

        //strenght
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            power = 3.8f;
            sel_2.localPosition = new Vector3(-212, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            power = 4f;
            sel_2.localPosition = new Vector3(-190, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            power = 4.2f;
            sel_2.localPosition = new Vector3(-168, 160, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            power = 4.6f;
            sel_2.localPosition = new Vector3(-212, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            power = 4.8f;
            sel_2.localPosition = new Vector3(-190, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            power = 5f;
            sel_2.localPosition = new Vector3(-168, 137.5f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            power = 5.2f;
            sel_2.localPosition = new Vector3(-212, 115, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            power = 5.4f;
            sel_2.localPosition = new Vector3(-190, 115, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            power = 5.6f;
            sel_2.localPosition = new Vector3(-168, 115, 0);
        }

        //direction
        int X = -Mathf.RoundToInt(_Camera.X);
        int Y = Mathf.RoundToInt(_Camera.Y) + 90;
        rotationx.text = "rotation y = " + X + "°";
        rotationy.text = "rotation x = " + Y + "°";
    }

    #endregion HUD

    #region Shoot

    public GameObject marble;
    public Camera cam;
    public Transform shootPoint;
    bool canFire = true;

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && canFire)
        {
            canFire = false;
            Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            Vector3 direction = ray.GetPoint(75) - shootPoint.position;
            GameObject currentMarble = Instantiate(marble, shootPoint.position, Quaternion.identity);
            currentMarble.GetComponent<Rigidbody>().AddForce(direction.normalized * power * 7, ForceMode.Impulse);
            Invoke("Wait", 2f);
        }
    }

    void Wait()
    {
        canFire = true;
    }

    #endregion Shoot
}
