using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHistoryProjectWebsite : MonoBehaviour {

	public Camera MainCamera;
	public GameObject BigCamera;

	public GameObject Pos0;
	public GameObject Pos1;
	public GameObject Pos2;
	public GameObject Pos3;
	public GameObject Pos4;
	public GameObject Pos5;
	public GameObject Pos6;
	public GameObject Pos7;
	public GameObject Pos8;
	public GameObject Pos9;
	public GameObject Pos10;
	public GameObject Pos11;
	public GameObject Pos12;

	public bool move0 = false;
	public bool move1 = false;
	public bool move2 = false;
	public bool move3 = false;
	public bool move4 = false;
	public bool move5 = false;
	public bool move6 = false;
	public bool move7 = false;
	public bool move8 = false;
	public bool move9 = false;
	public bool move10 = false;
	public bool move11 = false;
	public bool move12 = false;

	private Vector3 Angle0 = new Vector3 (30f, 0f, 0f);
	private Vector3 Angle1 = new Vector3 (0f, 90f, 0f);
	private Vector3 Angle2 = new Vector3 (30f, 180f, 0f);
	private Vector3 Angle3 = new Vector3 (0f, 270f, 0f);
	private Vector3 Angle4 = new Vector3 (0f, 0f, 0f);
	private Vector3 Angle5 = new Vector3 (0f, 135f, 0f);
	private Vector3 Angle6 = new Vector3 (0f, 90f, 0f);
	private Vector3 Angle7 = new Vector3 (30f, 0f, 0f);
	private Vector3 Angle8 = new Vector3 (0f, 180f, 0f);
	private Vector3 Angle9 = new Vector3 (30f, 270f, 0f);
	private Vector3 Angle10 = new Vector3 (0f, 270f, 0f);
	private Vector3 Angle11= new Vector3 (0f, 135f, 0f);
	private Vector3 Angle12 = new Vector3 (0f, 325f, 0f);

	public bool rotate0 = false;
	public bool rotate1 = false;
	public bool rotate2 = false;
	public bool rotate3 = false;
	public bool rotate4 = false;
	public bool rotate5 = false;
	public bool rotate6 = false;
	public bool rotate7 = false;
	public bool rotate8 = false;
	public bool rotate9 = false;
	public bool rotate10 = false;
	public bool rotate11 = false;
	public bool rotate12 = false;

	bool MoveToPos(GameObject Pos, bool move){

		if (Vector3.Distance(BigCamera.transform.position, Pos.transform.position) < 0.1f) {
			move = false;
			Debug.Log ("Reached " + Pos);
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
		else if (Input.GetKeyDown (KeyCode.Alpha6)) {
			Debug.Log ("6");
			move6 = true;
			rotate6 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha7)) {
			Debug.Log ("7");
			move7 = true;
			rotate7 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha8)) {
			Debug.Log ("8");
			move8 = true;
			rotate8 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Alpha9)) {
			Debug.Log ("9");
			move9 = true;
			rotate9 = true;
		}
		else if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("10");
			move10 = true;
			rotate10 = true;
		}
		else if (Input.GetKeyDown (KeyCode.W)) {
			Debug.Log ("11");
			move11 = true;
			rotate11 = true;
		}
		else if (Input.GetKeyDown (KeyCode.E)) {
			Debug.Log ("12");
			move12 = true;
			rotate12 = true;
		}
			

		move0 = MoveToPos (Pos0, move0);
		move1 = MoveToPos (Pos1, move1);
		move2 = MoveToPos (Pos2, move2);
		move3 = MoveToPos (Pos3, move3);
		move4 = MoveToPos (Pos4, move4);
		move5 = MoveToPos (Pos5, move5);
		move6 = MoveToPos (Pos6, move6);
		move7 = MoveToPos (Pos7, move7);
		move8 = MoveToPos (Pos8, move8);
		move9 = MoveToPos (Pos9, move9);
		move10 = MoveToPos (Pos10, move10);
		move11 = MoveToPos (Pos11, move11);
		move12 = MoveToPos (Pos12, move12);

		rotate0 = RotateToAngle (Angle0, rotate0);
		rotate1 = RotateToAngle (Angle1, rotate1);
		rotate2 = RotateToAngle (Angle2, rotate2);
		rotate3 = RotateToAngle (Angle3, rotate3);
		rotate4 = RotateToAngle (Angle4, rotate4);
		rotate5 = RotateToAngle (Angle5, rotate5);
		rotate6 = RotateToAngle (Angle6, rotate6);
		rotate7 = RotateToAngle (Angle7, rotate7);
		rotate8 = RotateToAngle (Angle8, rotate8);
		rotate9 = RotateToAngle (Angle9, rotate9);
		rotate10 = RotateToAngle (Angle10, rotate10);
		rotate11 = RotateToAngle (Angle11, rotate11);
		rotate12 = RotateToAngle (Angle12, rotate12);

	}

}
