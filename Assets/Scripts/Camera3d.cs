using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float distance = 10.0f; 
    public float height = 5.0f; 

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;

        transform.position = desiredPosition;

        transform.LookAt(target);
    }
}
