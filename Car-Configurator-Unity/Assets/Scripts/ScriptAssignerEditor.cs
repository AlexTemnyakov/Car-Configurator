using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ScriptAssigner))]
public class ScriptAssignerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ScriptAssigner __target = target as ScriptAssigner;

        if (GUILayout.Button("Assign rim configurators"))
            __target.AssignRimConfigurators();
    }
}
