using UnityEditor;

public static class Menu {

	[MenuItem("Assets/Create/COMBAT/Item")]
	public static void CreateItem() {
		ScriptableObjects.CreateAsset<Item>("Assets/Items");
	}

	// [MenuItem("Assets/Create/COMBAT/Weapon Attribute")]
	// public static void CreateWeaponAttribute() {
	// 	ScriptableObjects.CreateAsset<WeaponAttribute>("Assets/Attributes");
	// }
}
