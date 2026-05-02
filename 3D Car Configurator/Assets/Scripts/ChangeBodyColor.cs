using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBodyColor : MonoBehaviour
{
    public Transform excludedParent;

    public PartHistory history;

    private Color currentColor = Color.white;
    
    public CarResetSnapshot reset;

    void Start()
    {
        if (history != null && reset != null)
        {
            history.SetOriginalState(() =>
            {
                ApplyColor(reset.originalBodyColor);
            });
        }
    }
    public void ChangeColor(Color color)
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>();
        Color newColor = color;

        ApplyColor(newColor);

        history.AddState(() =>
        {
            ApplyColor(newColor);
        });
}

    void ApplyColor(Color color)
    {
        currentColor = color;

        Renderer[] renderers = GetComponentsInChildren<Renderer>();

        foreach (Renderer rend in renderers)
        {
            if (excludedParent != null && rend.transform.IsChildOf(excludedParent))
                continue;

            MaterialPropertyBlock block = new MaterialPropertyBlock();
            rend.GetPropertyBlock(block);

            block.SetColor("_BaseColor", color);
            block.SetColor("_Color", color);

            rend.SetPropertyBlock(block);
        }
    }
}