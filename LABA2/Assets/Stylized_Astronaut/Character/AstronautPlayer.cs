using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
namespace AstronautPlayer1
{

	public class AstronautPlayer : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;
		public int countColl = 0;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		void Start () {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){
			if (countColl >= 2)
			{
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
			if (Input.GetKey ("w")) {
				anim.SetInteger ("AnimationPar", 1);
			}  else {
				anim.SetInteger ("AnimationPar", 0);
			}

			if(controller.isGrounded){
				moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			}

			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			moveDirection.y -= gravity * Time.deltaTime;

            Ray ray = new Ray(transform.position, transform.forward * 2);
            Debug.DrawRay(transform.position, transform.forward * 2, Color.green);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Sun")
                {
                    Debug.Log("Victory");
                }
            }
        }
	}
}
