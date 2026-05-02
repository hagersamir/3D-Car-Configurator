using UnityEngine;
using UnityEngine.UI;

public class RGBController : MonoBehaviour
{
    public Slider r, g, b;
    public ChangeBodyColor body;
    public PartSelector selector;

    public void OnValueChanged()
    {
        selector.HideCurrentShield(); 

        Color c = new Color(r.value, g.value, b.value);
        body.ChangeColor(c);
        CarState.Instance.bodyHistory.Add(
    "RGB: " + c.r.ToString("0.00") + "," +
    c.g.ToString("0.00") + "," +
    c.b.ToString("0.00")
);
    }
}