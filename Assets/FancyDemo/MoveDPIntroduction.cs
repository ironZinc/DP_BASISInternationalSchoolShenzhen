using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDPIntroduction : MonoBehaviour {

	public Camera MainCamera;
	public GameObject BigCamera;

	float rotSpeed = 8f;

	public GameObject Propane;
	public GameObject Graph;

	public GameObject Pos0;
	public GameObject Pos1;
	public GameObject Pos2;
	public GameObject Pos3;
	public GameObject Pos4;
    public GameObject Pos5;

	public bool move0 = false;
	public bool move1 = false;
	public bool move2 = false;
	public bool move3 = false;
	public bool move4 = false;
	public bool move5 = false;


	private Vector3 Angle0 = new Vector3 (30f, 0f, 0f);
	private Vector3 Angle1 = new Vector3 (0f, 0f, 0f);
	private Vector3 Angle2 = new Vector3 (0f, 180f, 0f);
	private Vector3 Angle3 = new Vector3 (0f, 90f, 0f);
	private Vector3 Angle4 = new Vector3 (55f, 0f, 0f);
	private Vector3 Angle5 = new Vector3 (0f, 270f, 0f);

	public bool rotate0 = false;
	public bool rotate1 = false;
	public bool rotate2 = false;
	public bool rotate3 = false;
	public bool rotate4 = false;
	public bool rotate5 = false;

	bool MoveToPos(GameObject Pos, bool move){

		if (Vector3.Distance(BigCamera.transform.position, Pos.transform.position) < 0.1f) {
			move = false;
			Debug.Log ("Reached " + Pos);
			if(Pos == Pos3)
			{
				float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        		float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        		Propane.transform.RotateAround(Vector3.up, -rotX);
        		Propane.transform.RotateAround(Vector3.right, rotY);
			}
			if(Pos == Pos2)
			{
				float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
       			float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        		Graph.transform.RotateAround(Vector3.up, -rotX);
        		Graph.transform.RotateAround(Vector3.right, rotY);
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

//		if (MainCamera.transform.rotation.x == Angle.x && MainCamera.transform.rotation.y == Angle.y || MainCamera.transform.rotation.z == Angle.z){
//			rotate = false;
//		} else { rotate = true;}

//		if (rotate == true){
//			Vector3 newAngleVector;
//			Quaternion MainCamRotation = MainCamera.transform.rotation;
//			newAngleVector.x = Angle.x - MainCamRotation.x;
//			newAngleVector.y = Angle.y - MainCamRotation.y;
//			newAngleVector.z = Angle.z - MainCamRotation.z;
//			float speed = 0.1f * Time.deltaTime;
//			Vector3 newAngle = Vector3.RotateTowards(MainCamera.transform.forward, newAngleVector, speed, 0f);
//			transform.rotation = Quaternion.LookRotation(newAngle);
//		}

//		float RotationAngleX = Angle.x - MainCamera.transform.eulerAngles.x;
//		float RotationAngleY = Angle.y - MainCamera.transform.eulerAngles.y;
//		float RotationAngleZ = Angle.z - MainCamera.transform.eulerAngles.z;
//		bool RotateX;
//		bool RotateY;
//		bool RotateZ;
//
//		if (MainCamera.transform.eulerAngles.x <= Angle.x + 0.5 && MainCamera.transform.eulerAngles.x >= Angle.x - 0.5) {
//			RotateX = false;
//		} else { RotateX = true;}
//		if (MainCamera.transform.eulerAngles.y <= Angle.y + 0.5 && MainCamera.transform.eulerAngles.y >= Angle.y - 0.5) {
//			RotateY = false;
//		} else { RotateY = true;}
//		if (MainCamera.transform.eulerAngles.z <= Angle.z + 0.5 && MainCamera.transform.eulerAngles.z >= Angle.z - 0.5) {
//			RotateZ = false;
//		} else { RotateZ = true;}
//
//		if (RotateX == false && RotateY == false && RotateZ == false) {
//			rotate = false;
//		}
//		if (rotate == true) {
//
//
//			if (RotateX == true) {
//				if (RotationAngleX > 0) {
//					Debug.Log ("Rotating +x Target:" + Angle.x + " Current: " + MainCamera.transform.eulerAngles.x + " Difference: " + RotationAngleX);
//					MainCamera.transform.Rotate (Angle.x / 200f, 0f, 0f);
//				} else if (RotationAngleX < 0) {
//					Debug.Log ("Rotating -x Target:" + Angle.x + " Current: " + MainCamera.transform.eulerAngles.x + " Difference: " + RotationAngleX);
//					MainCamera.transform.Rotate (Angle.x / -200f, 0f, 0f);
//				} else if (RotationAngleX == 0) {
//					Debug.Log ("Rotating x 0");
//					MainCamera.transform.Rotate (0f, 0f, 0f);
//				}
//			}
//
//			if (RotateY == true) {
//				if (RotationAngleY > 0) {
//					Debug.Log ("Rotating +y Target:" + Angle.y + " Current: " + MainCamera.transform.eulerAngles.y + " Difference: " + RotationAngleY);
//					//MainCamera.transform.Rotate (0f, Angle.y / 200f, 0f);
//					MainCamera.transform.eulerAngles.x += Angle.x/200;
//				} else if (RotationAngleY < 0) {
//					Debug.Log ("Rotating -y Target:" + Angle.y + " Current: " + MainCamera.transform.eulerAngles.y + " Difference: " + RotationAngleY);
//				   //MainCamera.transform.Rotate (0f, Angle.y / -200f, 0f);
//					MainCamera.transform.eulerAngles.x -= Angle.x/200;
//				} else if (RotationAngleY == 0) {
//					Debug.Log ("Rotating y 0");
//					//MainCamera.transform.Rotate (0f, 0f, 0f);
//				}
//			}
//				
//			if (RotateZ == true) {
//				if (RotationAngleZ > 0) {
//					Debug.Log ("Rotating +z Target:" + Angle.z + " Current: " + MainCamera.transform.eulerAngles.z + " Difference: " + RotationAngleZ);
//					MainCamera.transform.Rotate (0f, 0f, Angle.z / 200f);
//				} else if (RotationAngleZ < 0) {
//					Debug.Log ("Rotating -z Target:" + Angle.z + " Current: " + MainCamera.transform.eulerAngles.z + " Difference: " + RotationAngleZ);
//					MainCamera.transform.Rotate (0f, 0f, Angle.z / -200f);
//				} else if (RotationAngleZ == 0) {
//					Debug.Log ("Rotating z 0");
//					MainCamera.transform.Rotate (0f, 0f, 0f);
//				}
//			}
		//}
			
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
		else if (Input.GetKeyDown (KeyCode.Alpha5)) {
			Debug.Log ("5");
			move5 = true;
			rotate5 = true;
		}
			

		move0 = MoveToPos (Pos0, move0);
		move1 = MoveToPos (Pos1, move1);
		move2 = MoveToPos (Pos2, move2);
		move3 = MoveToPos (Pos3, move3);
		move4 = MoveToPos (Pos4, move4);
		move5 = MoveToPos (Pos5, move5);

		rotate0 = RotateToAngle (Angle0, rotate0);
		rotate1 = RotateToAngle (Angle1, rotate1);
		rotate2 = RotateToAngle (Angle2, rotate2);
		rotate3 = RotateToAngle (Angle3, rotate3);
		rotate4 = RotateToAngle (Angle4, rotate4);
		rotate5 = RotateToAngle (Angle5, rotate5);

	}

}
