using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2p4 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "under")
        {
            Debug.Log("Hit under cube");
            float posX = collision.gameObject.transform.position.x;
            float posY = collision.gameObject.transform.position.y;
            float posZ = collision.gameObject.transform.position.z;
            Debug.Log($"{posX},{posY},{posZ}");
            collision.gameObject.transform.position = new Vector3(posX + speed, posY, posZ);
        }
        else
        {
            Debug.Log("nothing happend");
        }
    }



}
