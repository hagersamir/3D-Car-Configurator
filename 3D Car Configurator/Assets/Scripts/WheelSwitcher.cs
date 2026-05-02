using UnityEngine;

public class WheelSwitcher : MonoBehaviour
{
    public GameObject[] wheelStyles;
    public PartSelector selector;

    public PartHistory history;

    private int currentIndex = 0;

    void Start()
    {
        currentIndex = GetActiveIndex();
    }


public void SetWheel(int index)
{
    selector.HideCurrentShield();

    ApplyWheel(index);

    int savedIndex = index;

    history.AddState(() =>
    {
        ApplyWheel(savedIndex);
    });

    CarState.Instance.wheelHistory.Add("Style " + index);
}

    void ApplyWheel(int index)
    {
        currentIndex = index;

        for (int i = 0; i < wheelStyles.Length; i++)
        {
            wheelStyles[i].SetActive(i == index);
        }

      
        CarState.Instance.wheelHistory.Add("Style " + index);
    }

    int GetActiveIndex()
    {
        for (int i = 0; i < wheelStyles.Length; i++)
        {
            if (wheelStyles[i].activeSelf)
                return i;
        }
        return 0;
    }

  
    public void ForceSetWheel(int index)
    {
        ApplyWheel(index);
    }
}