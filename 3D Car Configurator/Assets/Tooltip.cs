using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public static Tooltip Instance;

    public TextMeshProUGUI label;
    public GameObject panel;

    void Awake()
    {
        Instance = this;
    }

    void Update()
{
    if (panel.activeSelf)
    {
        // panel.transform.position = Input.mousePosition;
        panel.transform.position = Input.mousePosition + new Vector3(90, -90, 0);
    }
}

    public void Show(string text)
    {
        panel.SetActive(true);
        label.text = text;
    }

    public void Hide()
    {
        panel.SetActive(false);
    }
}