using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyTask1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision myCollision)
    {
        if(myCollision.gameObject.name == "Floor")
        {
            Debug.Log("Hit the floor");
        }
        else if(myCollision.gameObject.name == "Wall")
        {
            Debug.Log("Hit the wall");
        }
    }
}
