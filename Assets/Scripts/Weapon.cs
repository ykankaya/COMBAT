using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	// Use this for initialization

	private Animator animator;
	private new Collider collider;

	void Start () {
		animator = gameObject.GetComponent<Animator>();
		gameObject.AddComponent<BoxCollider>();
		collider = gameObject.GetComponent<Collider>();
	}

	public void Charge() {
		collider.isTrigger = false;
		animator.SetTrigger("Charge");
		animator.SetBool("Hold", true);
	}

	public void Attack() {
		collider.isTrigger = true;
		animator.SetBool("Hold", false);
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnTriggerEnter(Collider collider) {
		this.collider.isTrigger = false;
		Debug.Log("here");
	}

	private bool AnimationIsPlaying(string stateName, bool includeTransition = false) {
		return animator.GetCurrentAnimatorStateInfo(0).IsName(stateName) && (includeTransition || animator.IsInTransition(0));
	}
}
