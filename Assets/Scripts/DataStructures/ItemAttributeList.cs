using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ItemAttributeList {

	[InspectorHide] public Item parent;

	public List<ItemAttribute> list;

	[Serializable]
	public class ParentList<C> : List<C> where C : ItemAttribute {

		[InspectorHide] Item parent;

		public ParentList(Item parent) {
			this.parent = parent;
		}
		// public new C this[int i] {
		// 	get {return base[i];}
		// 	set {value.parent = this.parent; base[i] = value; Debug.Log(value);}
		// }

		// public new void Add(C attribute) 
//{		// 	attribute.parent = this.parent;
		// 	Debug.Log("here");


		// 	base.Add(attribute);
		// }
	}

	public ItemAttributeList(Item parent) {
		this.parent = parent;
		list = new ParentList<ItemAttribute>(parent);
	}

	public ItemAttribute this[int i] {
		get {return list[i];}
		set {value.parent = this.parent; list[i] = value;}
	}
}
