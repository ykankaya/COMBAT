using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour {
	

	private Transform chtransform;
	public Character character;
	

	// Distance from camera to character.

	float sensitivityZoom = 1.2f;
	const float DIST_MIN  =   1f;
	const float DIST_MAX  =  15f;
	float _distance = 10f;
	float distance {
		get {return _distance;}
		set {_distance = Mathf.Clamp(value, DIST_MIN, DIST_MAX);}
	}
	

	float sensitivityX =    4f;
	const float X_MIN  = -180f;
	const float X_MAX  =  180f;
	float _x = 0f;
	float x {
		get {return _x;}
		set {_x = Mathf.Clamp(value, X_MIN, X_MAX);}
	}

	float sensitivityY =    6f;
	const float Y_MIN  =    0f;
	const float Y_MAX  =   50f;
	float _y = 0f;
	float y {
		get {return _y;}
		set {_y = Mathf.Clamp(value, Y_MIN, Y_MAX);}
	}
	
	void Start() {
		chtransform = character.transform;
	}

	void Update() {
		Vector3 moveDir = gameObject.transform.rotation * new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    character.Move(moveDir);
		if (Input.GetButtonUp("Jump")) {
    	character.Jump();
    }
    if (Input.GetMouseButtonDown(0)) {
    	character.Charge();
    }
    if (Input.GetMouseButtonUp(0)) {
    	character.Attack();
    }
	}
	
	void LateUpdate() { // after the movement of the player
		// GetAxisRaw prevents smoothing
    x        += sensitivityX    * Input.GetAxis("Mouse X"); // detect mouse movement
		y        += sensitivityY    * Input.GetAxis("Mouse Y"); // ""
    distance -= sensitivityZoom * Input.GetAxis("Mouse ScrollWheel");

		
		Vector3 fromDirection = Vector3.back; // south relative to character
		Quaternion rotation = Quaternion.Euler(y, x, 0); 
		// rotating *around* x (pitch) changes height, *around* y (yaw) changes direction - that's why they're flipped. 
		// (Rotation around z (roll) would make the camera tilt.)
		transform.position = chtransform.position + distance * (rotation * fromDirection);
		transform.LookAt(chtransform.position);
		chtransform.eulerAngles = new Vector3(chtransform.eulerAngles.x, transform.eulerAngles.y, chtransform.eulerAngles.z);
	}
}