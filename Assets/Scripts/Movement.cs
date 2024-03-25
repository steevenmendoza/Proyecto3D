using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public float speed = 10.0f; 
    public float rotationSpeed = 100.0f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void FixedUpdate()
    {
        // Obtener inputs del usuario
        float moveVertical = Input.GetAxis("Vertical"); 
        float moveHorizontal = Input.GetAxis("Horizontal"); 

        
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        
        float rotation = moveHorizontal * rotationSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(0, rotation, 0);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
