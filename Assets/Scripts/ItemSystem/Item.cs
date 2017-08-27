using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Item : ScriptableObject {
	public new string name;
	public string description;
	public float weight;
	public Sprite sprite;
	public GameObject model;
	
	public ItemAttributeList attributes;

	void OnEnable() {
		attributes = new ItemAttributeList(this);
	}
}