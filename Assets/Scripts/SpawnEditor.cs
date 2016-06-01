using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SpawnArea))]

public class SpawnEditor : Editor {

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		SpawnArea myScript = (SpawnArea)target;
		if(GUILayout.Button("Spawn Dudes"))
		{
			myScript.SpawnChilren();
		}
	}
}
