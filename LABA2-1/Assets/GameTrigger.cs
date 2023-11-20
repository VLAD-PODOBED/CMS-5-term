using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
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
        if (other.gameObject.tag == "Player")
        {
            if (!touched)
            {
                Debug.Log($"Hit trigger {touched}");
                touched = true;

            }
            else
            {
                Debug.Log($"Hit trigger {touched}");
                touched = false;

            }
        }
    }
}
