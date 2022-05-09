using UnityEngine;
using System.Collections.Generic;

public class magnets : MonoBehaviour
{
    List<Rigidbody> rbObs = new List<Rigidbody>();

    private void FixedUpdate()
    {
        foreach (Rigidbody rbOb in rbObs)
        {
            if (GetComponentInParent<type>().mode == 3) rbOb.AddForce((transform.position - rbOb.position) * 300 * Time.fixedDeltaTime);
            if (GetComponentInParent<type>().mode == 2) rbOb.AddForce((rbOb.position - transform.position) * 300 * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("obstacle")) rbObs.Add(other.GetComponent<Rigidbody>());
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("obstacle")) rbObs.Remove(other.GetComponent<Rigidbody>());
    }
}