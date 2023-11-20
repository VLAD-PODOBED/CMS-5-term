using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRedCubes : MonoBehaviour
{
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
            GameObject[] redcubes = GameObject.FindGameObjectsWithTag("Red");
            foreach(GameObject red in redcubes)
            {
                Destroy(red);
            }
        }
    }
}
