using UnityEngine;

public class destroy : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (transform.position.y < 0) Destroy(gameObject);
    }
}   
