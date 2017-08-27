using System.Collections.Generic;
using System;
using UnityEngine;

public class ParentList<C, P> where C : ParentListChild<C, P> {

	[ReadOnly] public P parent;

	public List<C> list; 
	
	public C this[int i] {
		get {return list[i];}
		set {value.parent = this.parent; list[i] = value;}
	}
}
