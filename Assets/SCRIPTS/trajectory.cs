using System.Collections.Generic;
using UnityEngine;

public class trajectory : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public LayerMask CollidableLayers;

    void Update()
    {
        lineRenderer.positionCount = 50;
        List<Vector3> points = new List<Vector3>();
        Vector3 startingPosition = transform.position;
        Vector3 startingVelocity = transform.forward * (FIRE_hud.power - .4f) * 7;
        for (float t = 0; t < 50; t += .1f)
        {
            Vector3 newPoint = startingPosition + t * startingVelocity;
            newPoint.y = startingPosition.y + startingVelocity.y * t + Physics.gravity.y / 2 * t * t;
            points.Add(newPoint);

            if (Physics.OverlapSphere(newPoint, .9f, CollidableLayers).Length > 0)
            {
                lineRenderer.positionCount = points.Count;
                break;
            }
        }

        lineRenderer.SetPositions(points.ToArray());
    }
}
