using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ItemAttributeList))]
public class ItemAttributeListDrawer : PropertyDrawer {

	float testValue = 0f;
	
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
		// EditorGUI.BeginProperty(position, label, property);


		// EditorGUIUtility.LookLikeControls();
		ItemAttributeList.ParentList<ItemAttribute> list = (ItemAttributeList.ParentList<ItemAttribute>) ((ItemAttributeList) fieldInfo.GetValue(property.serializedObject.targetObject)).list;


		float lineHeight = position.height + 2f;
		// Attributes
		var xPos = position.x;
		position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
		position.x = xPos;
		// position.y += lineHeight;
		position.width = EditorGUIUtility.currentViewWidth - 19f; // - EditorGUIUtility.fieldWidth;
		// position.width = Screen.width;
		// property.ListRelativeProperties();
		// property.ListRelativeProperties();
		// EditorGUI.PropertyField(position, property.FindPropertyRelative("list.Array.size"));
		position.y += lineHeight;

		var spList = property.FindPropertyRelative("list");
		for (int i = 0 ; i < spList.arraySize ; i++) {
			EditorGUI.PropertyField(position, spList.GetArrayElementAtIndex(i));
			position.y += lineHeight;
		}
		
		// position.width /= 2;
   	if (GUI.Button(position, "Add")) {
   		list.Add(new ItemAttribute());
   		// spList.InsertArrayElementAtIndex(spList.arraySize);
   	}
   	// position.x += position.width;


		// position.width = inspectorWidth; // EditorGUIUtility.labelWidth;

		// EditorGUILayout.PropertyField(property.FindPropertyRelative("parent"), GUIContent.none);
		// Debug.Log(position);

		// EditorGUI.EndProperty();
	}
}