using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject prefab;

    // Instantiate the prefab somewhere between -10.0 and 10.0 on the x-z plane 
    void Start()
    {
        prefab.tag = "greenCube";
        for (int i = 0; i < 3; i++)
        {
            Vector3 position = new Vector3(Random.Range(-6.0f, 6.0f), 0.5f, Random.Range(-6.0f, 6.0f));
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
    


}