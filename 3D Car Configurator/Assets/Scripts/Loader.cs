using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Loader : MonoBehaviour
{
    public GameObject loadingUI;
    public Slider progressBar;
    private static bool hasLoaded = false;
    public string sceneName = "3DConfiguratorScene";

    private void Start()
{
    if (hasLoaded) return;

    hasLoaded = true;
    StartCoroutine(LoadSceneAsync(sceneName));
}

    private IEnumerator LoadSceneAsync(string sceneName)
    {
        loadingUI.SetActive(true);
        progressBar.value = 0f;
        yield return null;


        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        op.allowSceneActivation = false;

        float fakeProgress = 0f;

        while (op.progress < 0.9f)
        {
            float real = op.progress / 0.9f;

      
            fakeProgress = Mathf.MoveTowards(fakeProgress, real, Time.deltaTime * 2f);

            progressBar.value = fakeProgress;
          

            yield return null;
        }

        //  ensure full bar fill
        while (fakeProgress < 1f)
        {
            fakeProgress = Mathf.MoveTowards(fakeProgress, 1f, Time.deltaTime * 2f);
            progressBar.value = fakeProgress;

            yield return null;
        }

        yield return new WaitForSeconds(0.2f);

        op.allowSceneActivation = true;
        loadingUI.SetActive(false);
    }
}