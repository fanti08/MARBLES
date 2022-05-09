using UnityEngine;

public class type : MonoBehaviour
{
    public Material[] mats;
    Renderer rend;
    public int mode = 1;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        Type();
        weasel_();
    }

    public static int magnet = 0;

    private void Type()
    {
        if (transform.position.x > 44)
        {
            switch (FIRE_hud.mode)
            {
                case 1:
                    //basic
                    mode = 1;
                    rend.material = mats[0];
                    break;
                case 2:
                    //antigravity
                    mode = 2;
                    rend.material = mats[1];
                    break;
                case 3:
                    //singularity
                    mode = 3;
                    rend.material = mats[2];
                    break;
                case 4:
                    //wild weasel
                    mode = 4;
                    rend.material = mats[3];
                    break;
                case 5:
                    //teleporter
                    mode = 5;
                    rend.material = mats[4];
                    break;
                case 6:
                    //maximum
                    mode = 6;
                    rend.material = mats[5];
                    break;
            }
        }
    }

    bool canWeaselGoAround = true;
    bool isWeaselInvoked = false;
    bool canPlayVacuum = true;
    bool canPlayTheThingSimilarToTheVacuumButThatIDoNotKnowWhatIsGoingToBeAlthoughIHaveToNameTheVariableSomeWaySoYeah = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (mode == 6 && transform.localScale != new Vector3(3, 3, 3))
        {
            transform.localScale = new Vector3(3, 3, 3);
            GameObject.Find("maximum").GetComponent<AudioSource>().Play();
        }
        if (mode == 5 && collision.collider.tag == "obstacle")
        {
            collision.collider.transform.position = new Vector3(Random.Range(-40, -10), 30, Random.Range(-15, 15));
            GameObject.Find("teleporter").GetComponent<AudioSource>().Play();
        }
        if (mode == 4) isWeaselInvoked = true;
        if (mode == 3 && canPlayVacuum)
        {
            canPlayVacuum = false;
            GameObject.Find("singularity").GetComponent<AudioSource>().Play();
        }
        if (mode == 2 && canPlayTheThingSimilarToTheVacuumButThatIDoNotKnowWhatIsGoingToBeAlthoughIHaveToNameTheVariableSomeWaySoYeah)
        {
            canPlayTheThingSimilarToTheVacuumButThatIDoNotKnowWhatIsGoingToBeAlthoughIHaveToNameTheVariableSomeWaySoYeah = false;
            GameObject.Find("antigravity").GetComponent<AudioSource>().Play();
        }
    }

    void weasel_()
    {
        if (isWeaselInvoked && canWeaselGoAround)
        {
            canWeaselGoAround = false;
            Invoke("weasel", 1);
        }
    }

    void weasel()
    {
        canWeaselGoAround = true;
        GetComponent<Rigidbody>().AddForce((Vector3.forward + new Vector3(Random.Range(-50,50), 0, Random.Range(-50, 50))), ForceMode.Impulse);
        GameObject.Find("wild weasel").GetComponent<AudioSource>().Play();
    }
}
