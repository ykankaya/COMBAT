using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(InspectorHideAttribute))]
public class InspectorHideDrawer : PropertyDrawer {

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
		return -2f; // ayy lmao
  }
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
    // GUI.enabled = false;
    // EditorGUI.PropertyField(position, property, label, true);
    // GUI.enabled = true;
    // GUI.enabled = false;
  }
}
