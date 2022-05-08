using UnityEngine;

public class capableCameraOfNavigationThing : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    float distanceToTarget = 50;
    Vector3 previousPosition;

    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0) distanceToTarget -= 750 * Time.deltaTime;
        if (Input.mouseScrollDelta.y < 0) distanceToTarget += 750 * Time.deltaTime;
        distanceToTarget = Mathf.Clamp(distanceToTarget, 20, 100);

        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0) || Input.mouseScrollDelta.y != 0)
        {
            Vector3 newPosition = previousPosition;
            if (Input.mouseScrollDelta.y == 0) newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180;
            float rotationAroundXAxis = direction.y * 180; 

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), rotationAroundXAxis);
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World);

            cam.transform.Translate(new Vector3(0, 0, -distanceToTarget));

            previousPosition = newPosition;
        }
    }
}
