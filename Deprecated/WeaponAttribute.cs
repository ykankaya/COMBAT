using UnityEngine;
using UnityEditor.Animations;

/// For items that can be swung, thrusted, etc. to deal damage.
/// They also provide dynamic protection (the player must react to attacks).
public class WeaponAttribute : EquipmentAttribute {
	
	public WeaponType type;
	private Material material;


}