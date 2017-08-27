using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;


public class Character : MonoBehaviour {

	public CharacterData data;
	// public List<ItemData> inventory;
	public Dictionary<EquipmentSlot, GameObject> equipment = new Dictionary<EquipmentSlot, GameObject>();
	// public Weapon weapon;
	new Rigidbody rigidbody;
	new Collider  collider;
	// WeaponAttribute attr;

	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody>();
		collider  = gameObject.GetComponent<Collider>();
		// attr = (WeaponAttribute) ((Item) AssetDatabase.LoadAssetAtPath("Assets/Items/Sword.asset", typeof(Item))).attributes[0];
		// this.Equip(attr);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Move(Vector3 direction) {
		if (! data.flies) {
			if (! IsOnGround()) {
				return;
			}
			direction.y = 0;
		}
		direction.Normalize();
		rigidbody.velocity = data.speed * direction + Vector3.up * rigidbody.velocity.y;
	}

	public void Jump() {
		if (IsOnGround()) {
			Vector3 v = rigidbody.velocity;
			rigidbody.velocity = new Vector3(v.x, 5f, v.z);
		}
	}

	// public void Equip(WeaponAttribute weaponAtt) {
	// 	var item = weaponAtt.parent;
	// 	var weaponType = weaponAtt.type;
	// 	var obj = Instantiate(item.model, 
	// 		gameObject.transform.position + weaponType.relativePosition, 
	// 		Quaternion.Euler(weaponType.initialRotation), 
	// 		gameObject.transform);
	// 	var animator = obj.GetComponent<Animator>();
	// 	animator.runtimeAnimatorController = weaponAtt.type.controller;
	// 	obj.AddComponent<Weapon>();
	// 	equipment[EquipmentSlot.MainHand] = obj;
	// }

	public void Charge() {
		equipment[EquipmentSlot.MainHand].GetComponent<Weapon>().Charge();
	}

	public void Attack() {
		equipment[EquipmentSlot.MainHand].GetComponent<Weapon>().Attack();
	}

	private bool IsOnGround() {
		return rigidbody.velocity.y == 0 || Physics.Raycast(transform.position, Vector3.down, collider.bounds.extents.y * 1.01f);
	}

	private float speed() {
		// return data.speed - weapon.weight / 100.0f
		return data.speed;
	}


}
