using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePoint : MonoBehaviour {
	private Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = camera.ScreenPointToRay (Input.mousePosition);
		Debug.DrawRay (ray.origin, ray.direction * 1000f, Color.red);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 1000))
			{
			Debug.Log (hit.collider.gameObject.name);
		}
	}
}
