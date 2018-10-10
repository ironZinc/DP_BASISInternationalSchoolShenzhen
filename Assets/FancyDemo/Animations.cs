using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

	public GameObject thing;
	public GameObject thing2;
	public GameObject a;
	public GameObject b;
	public GameObject c;
	public GameObject d;
	public GameObject can1;
	public GameObject can2;
	public GameObject screen;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
		{
			a.SetActive(true);
		}
		if(Input.GetKey(KeyCode.S))
		{
			b.SetActive(true);
		}
		if(Input.GetKey(KeyCode.D))
		{
			c.SetActive(true);
		}
		if(Input.GetKey(KeyCode.F))
		{
			d.SetActive(true);
		}
		if(Input.GetKey(KeyCode.G))
		{
			thing2.SetActive(true);
		}
		if(Input.GetKey(KeyCode.H))
		{
			thing.SetActive(true);
		}
		if(Input.GetKey(KeyCode.J))
		{
			can2.SetActive(true);
			can1.SetActive(false);
			screen.SetActive(false);
		}
	}
}
