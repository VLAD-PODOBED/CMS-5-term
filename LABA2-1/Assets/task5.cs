using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public float speed = 1;
    public float jumpForce = 10;
    private Rigidbody rb;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = false; // На старте объект считается на земле.
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Применяем силу вверх для выполнения прыжка.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Объект больше не находится на земле после прыжка.
        }


    }
    // При столкновении с землей, устанавливаем флаг isGrounded в true.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Untagged")) // Замените "Ground" на тег вашей поверхности.
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "greenCube")
        {
            Debug.Log("Hit under cube");
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("nothing happend");
        }
    }




}
