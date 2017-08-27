using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ItemAttributeList))]
public class ItemAttributeListEditor : Editor {
	
	public override void OnInspectorGUI() {
		ItemAttributeList myItemAttributeList = (ItemAttributeList) target;

		EditorGUILayout.IntField("Size", myItemAttributeList.list.Count);


	}
}