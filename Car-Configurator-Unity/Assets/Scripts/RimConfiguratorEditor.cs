using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RimConfigurator))]
public class RimConfiguratorEditor : Editor
{
    private Color chosenColor = Color.white;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        RimConfigurator __target = target as RimConfigurator;

        chosenColor = EditorGUILayout.ColorField("Chosen color", chosenColor);
        if (GUILayout.Button("Change color"))
            __target.ChangeColor(chosenColor);
    }
}
