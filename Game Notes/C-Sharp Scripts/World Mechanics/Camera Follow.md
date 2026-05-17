
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 4f;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (target == null)
        {
            Debug.Log("CameraFollow: No target assigned.");
            return;
        }

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
}