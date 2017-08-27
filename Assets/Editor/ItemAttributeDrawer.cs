using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ItemAttribute))]
public class ItemAttributeDrawer : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		// var it = property.Copy();
		// while (it.Next(true)) {
		// 	Debug.Log(it.name);
		// }
		
	}
}
