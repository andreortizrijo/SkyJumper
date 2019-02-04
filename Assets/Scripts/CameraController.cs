using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    private float camSpeed = 0.125f;

    public Vector3 offset;

    void LateUpdate()
    {   
        Vector3 desiredPosition = target.position + offset;
        Vector3 camPosition = Vector3.Lerp(transform.position, desiredPosition, camSpeed);
        transform.position = camPosition;
    }
}
