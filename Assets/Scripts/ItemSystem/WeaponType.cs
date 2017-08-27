using UnityEngine;
using UnityEditor.Animations;

public class WeaponType : ScriptableObject {
	public AnimatorController controller;
	public Vector3 relativePosition;
	public Vector3 initialRotation;
}