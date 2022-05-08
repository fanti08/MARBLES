using UnityEngine;

public class marbles : MonoBehaviour
{
    private void Update()
    {
        _Destroy();
    }

    #region DESTROY

    public Rigidbody rb;

    private void _Destroy()
    {
        DestroyIfFalling();
        DestroyIfStationary();
    }

    void DestroyIfFalling()
    {
        if (transform.position.y < 0) des();
    }

    void DestroyIfStationary()
    {
        if (Mathf.Abs(rb.velocity.x) <= .1f && Mathf.Abs(rb.velocity.y) <= .1f && Mathf.Abs(rb.velocity.z) <= .1f && transform.position.x < 44)
            Invoke("des", 10);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "ground") Invoke("des", 10);
    }

    void des()
    {
        Destroy(gameObject);
    }

    #endregion DESTROY
}
