using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task5p2 : MonoBehaviour
{
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (!touched)
            {
                Debug.Log($"Hit trigger {touched}");
                other.gameObject.transform.localScale = new Vector3(2F, 2F, 2F);
                touched = true;
               
            }
            else
            {
                Debug.Log($"Hit trigger {touched}");
                other.gameObject.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);
                touched = false;
                
            }
        }
    }
}