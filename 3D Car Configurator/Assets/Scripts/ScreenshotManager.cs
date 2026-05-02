using UnityEngine;

public class ScreenshotManager : MonoBehaviour
{
    public GameObject uiRoot; 

    public void TakeScreenshot()
    {
        StartCoroutine(Capture());
    }

    System.Collections.IEnumerator Capture()
    {
        // Hide UI
        uiRoot.SetActive(false);

        yield return new WaitForEndOfFrame();

        string folderPath = Application.dataPath + "/Screen shot/";

        if (!System.IO.Directory.Exists(folderPath))
            System.IO.Directory.CreateDirectory(folderPath);

        string fileName = "Car_" + System.DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
        string fullPath = folderPath + fileName;

        ScreenCapture.CaptureScreenshot(fullPath);

        yield return new WaitForSeconds(0.2f);

        // Show UI again
        uiRoot.SetActive(true);

        Debug.Log("Saved to: " + fullPath);
    }
}