using UnityEngine;
using System;
/// Item attributes add information to a context screen,
/// and accordingly dictate the characteristics of items when 
/// they are materialized into the game world.
[Serializable]
public class ItemAttribute {
	[InspectorHide] public Item parent;

}	

