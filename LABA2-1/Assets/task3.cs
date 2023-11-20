using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task3 : MonoBehaviour
{
    // Start is called before the first frame update
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
            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("nothing happend");
        }
    }
}
