using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentListChild<C, P> : ScriptableObject where C : ParentListChild<C, P> {

	public P parent;

	
}
