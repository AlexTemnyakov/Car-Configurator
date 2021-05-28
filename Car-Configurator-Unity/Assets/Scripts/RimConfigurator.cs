using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RimConfigurator : MonoBehaviour
{
    private MeshRenderer meshRenderer = null;

    public void ChangeColor(Color colorToSet)
    {
        if (meshRenderer == null)
        {
            meshRenderer = GetComponent<MeshRenderer>();

            if (meshRenderer == null)
                throw new System.Exception("There is no mesh renderer!");
        }

        meshRenderer.sharedMaterial.color = colorToSet;
    }
}
