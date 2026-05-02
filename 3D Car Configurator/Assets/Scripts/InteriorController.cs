using UnityEngine;

public class InteriorController : MonoBehaviour
{
    public Renderer interiorRenderer;
    public Material secondMaterial;

    public PartSelector selector; 
    public PartHistory history;

    public void ChangeColor(Color color)
    {
        selector.HideCurrentShield(); 
        Color appliedColor = color;

        interiorRenderer.material.SetColor("_BaseColor", appliedColor);

        history.AddState(() =>
        {
            interiorRenderer.material.SetColor("_BaseColor", appliedColor);
        });
      
          CarState.Instance.interiorHistory.Add("Material Changed");
      
    }

    public void ChangeMaterial()
    {
        selector.HideCurrentShield(); 

        interiorRenderer.material = secondMaterial;
    }
}