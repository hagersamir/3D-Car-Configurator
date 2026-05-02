using UnityEngine;

public class CarResetSnapshot : MonoBehaviour
{
    [Header("Original Body")]
    public Color originalBodyColor = Color.white;

    [Header("Original Wheels")]
    public int originalWheelIndex = 0;

    [Header("Original Windows")]
    public bool originalWindowState = false;

    [Header("Original Interior")]
    public Renderer interiorRenderer;
    public Material originalInteriorMaterial;
    public Color originalInteriorColor = Color.white;

    [Header("References")]
    public ChangeBodyColor body;
    public WheelSwitcher wheels;
    public WindowToggle windows;
    public InteriorController interior;

    public void ResetCar()
    {
    
        body.ChangeColor(originalBodyColor);
        
        wheels.SetWheel(originalWheelIndex);
      
        windows.ToggleWindow(originalWindowState);
  
        if (interiorRenderer != null && originalInteriorMaterial != null)
        {
            interiorRenderer.material = originalInteriorMaterial;
            interiorRenderer.material.SetColor("_BaseColor", originalInteriorColor);
        }
    }
}