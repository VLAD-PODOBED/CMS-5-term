using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redCube : MonoBehaviour
{
    public float speed;
    private bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float posZ = transform.position.z;
        if (!hit)
            transform.position = new Vector3(posX+speed,posY, posZ);
        else
            transform.position = new Vector3(posX-speed, posY, posZ);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "redCube")
        {
            Debug.Log("Hit under cube");
            hit = !hit;   
        }
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit under cube");
            Destroy(collision.gameObject);
        }

    }
}
