using UnityEngine;

public class Camerascript : MonoBehaviour
{
    public Transform Target;
    public float smooth = 0.120f;
    public Vector3 offset;

    void FixedUpdate ()
    {
        Vector3 desiredPosition = Target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smooth);
        transform.position = smoothedPosition;
    }


}
