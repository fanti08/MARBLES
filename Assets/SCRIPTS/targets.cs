using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class targets : MonoBehaviour
{
    public Text txt_captured;
    int captured = 0;

    private void Start()
    {
        PlayerPrefs.SetInt("captured", 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "marble")
        {
            captured = PlayerPrefs.GetInt("captured");
            captured++;
            PlayerPrefs.SetInt("captured", captured);
            if (captured == 5) SceneManager.LoadScene("boh");
            txt_captured.text = "CAPTURED: " + captured.ToString() + "/5";
            transform.position = new Vector3(Random.Range(42.25f, 47.75f), 1.6f, Random.Range(12.25f, 17.75f));
        }
    }
}
