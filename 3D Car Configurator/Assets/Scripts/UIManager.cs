
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public ConfiguratorPanelAnimator masterPanel;
    public UIPanelAnimator selectText;
    public UIPanelAnimator bodyPanel;
    public UIPanelAnimator wheelsPanel;
    public UIPanelAnimator windowsPanel;
    public UIPanelAnimator interiorPanel;
    public GameObject rgbPanel;
    public GameObject bodyMainContent;

    UIPanelAnimator currentPanel;

    void Awake()
    {
        Instance = this;
    }


    public void OpenUI()
    {
        masterPanel.Show();
        ShowDefault();
    }

    public void CloseUI()
    {
        masterPanel.Hide();
    }


    public void ShowPanel(string partName)
{
    masterPanel.Show();
    selectText.Hide();

    if (currentPanel != null)
        currentPanel.Hide();

    currentPanel = null;

    if (partName.Contains("Body"))
        currentPanel = bodyPanel;
    else if (partName.Contains("Wheel"))
        currentPanel = wheelsPanel;
    else if (partName.Contains("Window"))
        currentPanel = windowsPanel;
    else if (partName.Contains("Interior"))
        currentPanel = interiorPanel;

    if (currentPanel != null)
        currentPanel.Show();
}

    public void ShowDefault()
    {
        if (currentPanel != null)
            currentPanel.Hide();

        selectText.Show();
    }
    public void OpenRGBPanel()
    {
        if (rgbPanel != null)
            rgbPanel.SetActive(true);

        if (bodyMainContent != null)
            bodyMainContent.SetActive(false);
    }

    public void CloseRGBPanel()
    {
        if (rgbPanel != null)
            rgbPanel.SetActive(false);

        if (bodyMainContent != null)
            bodyMainContent.SetActive(true);
    }
}