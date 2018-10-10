using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour {

	public GameObject Pos2;
	public GameObject Pos3;
	public GameObject Propane;
	public GameObject Graph;
	public Camera MainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(MainCamera.transform.position, Pos2.transform.position) == 0)
		{
			Debug.Log("sdsd");
			Propane.gameObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 14f);
		} else if(Vector3.Distance(MainCamera.transform.position, Pos3.transform.position) == 0){
			Graph.gameObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * 14f);
		}
	}
}
