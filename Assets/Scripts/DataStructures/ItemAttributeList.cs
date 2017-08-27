using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemAttributeList {

	[InspectorHide] public Item item;

	public List<ItemAttribute> list;

	public ItemAttributeList(Item item) {
		this.item = item;
		list = new List<ItemAttribute>();
	}

	public ItemAttribute this[int i] {
		get {return list[i];}
		set {value.item = this.item; list[i] = value;}
	}

	public void Add(ItemAttribute attribute) {
		list.Add(attribute);
		attribute.item = this.item;
	}

}
