using AstronautPlayer1;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerKiller : MonoBehaviour
{
    public GameObject player; // —сылка на игрока
    public float chaseAngleThreshold = 45f; 
    public float chaseDistance = 4f;
    public float moveSpeed = 2f; 
    public bool findPlayer = false;
    public float rotationSpeed = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        if (findPlayer)
        {
            if (collision.gameObject.name == player.gameObject.name)
            {
                
                player.GetComponent<AstronautPlayer>().countColl += 1;
                Debug.Log(player.GetComponent<AstronautPlayer>().countColl);
            }
        }
        
    }
        private void Update()
    {

        
        if (player != null)
        {
            GetKillPlayer();
        }
        else
        {
            player = GameObject.Find("Stylized Astronaut");
            if(player != null)
            {
                GetKillPlayer();
            }
        }  
    }
    public void GetKillPlayer()
    {
        if (!findPlayer)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= chaseDistance)
            {
                if (Vector3.Dot(transform.forward, (player.transform.position - transform.position)) < 0.7)
                {
                    findPlayer = true;
                }

            }
        }
        else
        {
            Vector3 direction = player.transform.position - transform.position;

            direction.Normalize();
            transform.LookAt(player.transform);

            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
