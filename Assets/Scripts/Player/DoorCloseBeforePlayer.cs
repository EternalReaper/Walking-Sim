using UnityEngine;
using System.Collections;

public class DoorCloseBeforePlayer : MonoBehaviour {

		float smooth = 2.0f;
		float DoorOpenAngle = 90.0f;
		float DoorCloseAngle = 0.0f;
		bool open;
		bool enter;


	void Start()
	{
		open = true;
		enter = true;
	}


		void  OnTriggerEnter ( Collider other  )
		{
			if (other.gameObject.tag == "Player")
			{
				enter = false;
				print("close");
			}
		}

		void Update()
		{
			if(open == true)
			{
				print("if(open)");
				var target = Quaternion.Euler (0, DoorOpenAngle, 0);
				transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * smooth);
			}

			if(open == false)
			{
				print("if(!open)");
				var target1= Quaternion.Euler (0, DoorCloseAngle, 0);
				transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * smooth);
			}  

			if(enter == false)
			{
				//initiate sound file script to go here

				open = false;

			}
		}
	}