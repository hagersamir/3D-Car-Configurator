using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public ChangeBodyColor body;
    public InteriorController interior;

    public Color color;
    public string colorName;

    [Header("Target Type")]
    public string type; // "B" = Body, "I" = Interior

    public PartSelector selector;

    public void ApplyColor()
    {
        selector.HideCurrentShield();

        if (type == "B")
        {
            body.ChangeColor(color);
            CarState.Instance.bodyHistory.Add(colorName);
        }
        else if (type == "I")
        {
            interior.ChangeColor(color);
            CarState.Instance.interiorHistory.Add(colorName);
        }
        else
        {
            Debug.LogWarning("Invalid type! Use B or I");
        }
    }
}