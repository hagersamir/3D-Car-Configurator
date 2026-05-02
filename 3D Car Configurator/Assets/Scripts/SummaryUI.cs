using UnityEngine;
using TMPro;
using System.Text;
using System.Collections.Generic;

public class SummaryUI : MonoBehaviour
{
    public GameObject panel;

    [Header("UI Texts")]
    public TMP_Text bodyText;
    public TMP_Text interiorText;
    public TMP_Text wheelsText;
    public TMP_Text windowsText;

    public void ShowSummary()
    {
        panel.SetActive(true);
        UpdateSummary();
    }

    public void CloseSummary()
    {
        panel.SetActive(false);
    }

    void UpdateSummary()
    {
        var state = CarState.Instance;

        bodyText.text     = BuildSection("BODY", state.bodyHistory);
        interiorText.text = BuildSection("INTERIOR", state.interiorHistory);
        wheelsText.text   = BuildSection("WHEELS", state.wheelHistory);
        windowsText.text  = BuildSection("WINDOW", state.windowHistory);
    }

    List<string> Clean(List<string> list)
    {
        List<string> result = new List<string>();

        foreach (var item in list)
        {
            
            // remove consecutive duplicates
            if (result.Count == 0 || result[result.Count - 1] != item)
                result.Add(item);
        }

        return result;
    }

    string BuildSection(string title, List<string> list)
{
    StringBuilder sb = new StringBuilder();

    sb.AppendLine("== " + title + " =="); 

    var cleanList = Clean(list);

    if (cleanList.Count == 0)
    {
        sb.AppendLine("No color change");
        return sb.ToString();
    }

    for (int i = 0; i < cleanList.Count; i++)
    {
        sb.AppendLine($"{i + 1}. {cleanList[i]}");
    }

    return sb.ToString();
}
}