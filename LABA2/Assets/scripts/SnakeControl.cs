using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControl : MonoBehaviour
{
    public float moveSpeed = 5.0f; 
    public float rotationspeed = 10f;
    
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            //
            Vector3 directionVector = new Vector3(horizontalInput, 0, verticalInput);
            if (directionVector.magnitude > Mathf.Abs(0.1f))
            {
                float targetAngle = Mathf.Atan2(directionVector.x, directionVector.z) * Mathf.Rad2Deg;
                Quaternion targetRotation = Quaternion.Euler(0, targetAngle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationspeed);
            }
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationspeed);
            rb.velocity = directionVector * moveSpeed;
        }

        Ray ray = new Ray(transform.position, transform.forward * 2);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.name == "Sun")
            {
                Debug.Log("Victory");
            }
        }

    }
    //
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "EggLife")
            moveSpeed += 1f;
    }
    //
}
