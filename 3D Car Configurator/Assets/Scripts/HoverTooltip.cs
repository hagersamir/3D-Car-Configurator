using UnityEngine;

public class HoverTooltip : MonoBehaviour
{
    void OnMouseEnter()
    {
        Transform t = transform;

        
        while (t != null && !t.CompareTag("CarPart"))
        {
            t = t.parent;
        }

        if (t != null)
        {
            Tooltip.Instance.Show(t.name);
        }
    }

    void OnMouseExit()
    {
        Tooltip.Instance.Hide();
    }
}