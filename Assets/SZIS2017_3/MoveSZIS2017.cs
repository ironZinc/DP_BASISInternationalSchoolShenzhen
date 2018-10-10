using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSZIS2017 : MonoBehaviour {

	public Camera MainCamera;
	public GameObject BigCamera;

	public GameObject Propane;
	public GameObject Graph;


	public GameObject Pos0;
	public GameObject Pos1;
	public GameObject Pos2;
	public GameObject Pos3;
	public GameObject Pos4;

	public bool move0 = false;
	public bool move1 = false;
	public bool move2 = false;
	public bool move3 = false;
	public bool move4 = false;

	private Vector3 Angle0 = new Vector3 (30f, 0f, 0f);
	private Vector3 Angle1 = new Vector3 (0f, 90f, 0f);
	private Vector3 Angle2 = new Vector3 (30f, 180f, 0f);
	private Vector3 Angle3 = new Vector3 (0f, 270f, 0f);
	private Vector3 Angle4 = new Vector3 (0f, 0f, 0f);

	public bool rotate0 = false;
	public bool rotate1 = false;
	public bool rotate2 = false;
	public bool rotate3 = false;
	public bool rotate4 = false;

	bool MoveToPos(GameObject Pos, bool move){

		if (Vector3.Distance(BigCamera.transform.position, Pos.transform.position) < 0.1f) {
			move = false;
			Debug.Log ("Reached " + Pos);
			if(Pos == Pos2)
			{
				Propane.gameObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 120f);
			}else if(Pos == Pos3){
				Graph.gameObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), -Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 120f);
			}
		}

		if (move == true) {
			Debug.Log ("Going to " + Pos);
			transform.LookAt (Pos.transform);
			transform.position += transform.forward * Time.deltaTime * 12f;
		}

		return move;
	}

	bool RotateToAngle (Vector3 Angle, bool rotate){
		//Angle.x - MainCamera.transform.eulerAngles.x > 0.5f
		if (rotate == true){
			if ( Vector3.Distance(MainCamera.transform.eulerAngles, Angle) > 0.5f){
				MainCamera.transform.eulerAngles = Vector3.Lerp(MainCamera.transform.eulerAngles, Angle, Time.deltaTime/1f);
				Debug.Log ("Rotating");
			} 
			else{
				transform.eulerAngles = Angle;
				rotate = false;
				Debug.Log ("Rotation done");
			}

		}
			
		return rotate;
	}

	void Start () {
		
	}


	void Update () {
		
		MainCamera.transform.position = BigCamera.transform.position;

		if (Input.GetKeyDown (KeyCode.Alpha0)) {
			Debug.Log ("0");
			move0 = true;
			rotate0 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Debug.Log ("1");
			move1 = true;
			rotate1 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Debug.Log ("2");
			move2 = true;
			rotate2 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {

			Debug.Log ("3");
			move3 = true;
			rotate3 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha4)) {

			Debug.Log ("4");
			move4 = true;
			rotate4 = true;
		}
			

		move0 = MoveToPos (Pos0, move0);
		move1 = MoveToPos (Pos1, move1);
		move2 = MoveToPos (Pos2, move2);
		move3 = MoveToPos (Pos3, move3);
		move4 = MoveToPos (Pos4, move4);

		rotate0 = RotateToAngle (Angle0, rotate0);
		rotate1 = RotateToAngle (Angle1, rotate1);
		rotate2 = RotateToAngle (Angle2, rotate2);
		rotate3 = RotateToAngle (Angle3, rotate3);
		rotate4 = RotateToAngle (Angle4, rotate4);


	}

}
