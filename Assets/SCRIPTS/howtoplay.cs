using UnityEngine;

public class howtoplay : MonoBehaviour
{
    public GameObject panel;
    bool bho = false;

    public void clicked()
    {
        bho = !bho;
        panel.SetActive(bho);
    }
}
