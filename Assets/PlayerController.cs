using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Input.GetAxis ("Horizontal") * speed, 0);
		Vector3 direction = new Vector3(0, 0, Input.GetAxis("Vertical"));
		transform.Translate(Vector3.forward * Input.GetAxis("Vertical"));
	}
}
