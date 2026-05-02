using UnityEngine;

public class WindowToggle : MonoBehaviour
{
    public GameObject windowObject;
    public PartSelector selector;
    public PartHistory history;

    public void ToggleWindow(bool isOn)
    {
        selector.HideCurrentShield(); 


        bool newState = !isOn;

        // apply change
        windowObject.SetActive(newState);

      
        history.AddState(() =>
        {
            windowObject.SetActive(newState);
        });

        // CarState.Instance.windowHidden = isOn;\
        CarState.Instance.windowHistory.Add(isOn ? "Visible" : "Hidden");
    }
}