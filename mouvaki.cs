using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveee : MonoBehaviour {

	// Use this for initialization
	protected Joystick joystick;

	void Start () {
		joystick = FindObjectOfType<Joystick> ();
	}
	
	// Update is called once per frame
	void Update () {
		var rigitbody = GetComponent<Rigidbody> ();
		rigitbody.velocity = new Vector3 (joystick.Horizontal * 5f, rigitbody.velocity.y, joystick.Vertical * 5f);
		}
}
