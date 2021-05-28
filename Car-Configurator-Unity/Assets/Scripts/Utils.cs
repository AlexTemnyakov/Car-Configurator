using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Auxiliary functions.
/// </summary>
public class Utils : MonoBehaviour
{
    public static List<Transform> FindTransformsWithName(string requiredName)
    {
        GameObject[] gameObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

        List<Transform> ret = new List<Transform>();

        foreach (var o in gameObjects)
            ret.AddRange(FindTransformsWithName(requiredName, o.transform));

        return ret;
    }

    public static List<Transform> FindTransformsWithName(string requiredName, Transform root)
    {
        List<Transform> ret = new List<Transform>();

        _FindTransformsWithName(root, requiredName, ref ret);

        return ret;
    }

    private static void _FindTransformsWithName(Transform currentTransform, string requiredName, ref List<Transform> listOfTransformsWithRequiredName)
    {
        if (currentTransform.name == requiredName)
            listOfTransformsWithRequiredName.Add(currentTransform);

        for (int i = 0; i < currentTransform.childCount; i++)
            _FindTransformsWithName(currentTransform.GetChild(i), requiredName, ref listOfTransformsWithRequiredName);
    }
}
