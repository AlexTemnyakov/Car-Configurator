using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptAssigner : MonoBehaviour
{
    private readonly static string rimTransformName = "rim";

    public void AssignRimConfigurators()
    {
        List<Transform> rimTransforms = Utils.FindTransformsWithName(rimTransformName);

        foreach (var t in rimTransforms)
            if (t.gameObject.GetComponent<RimConfigurator>() == null)
                t.gameObject.AddComponent<RimConfigurator>();
    }
}
