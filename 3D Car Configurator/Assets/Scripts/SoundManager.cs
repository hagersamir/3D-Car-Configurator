using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource sfxSource;

    public AudioClip selectSound;
    public AudioClip panelOpenSound;
    public AudioClip clickSound;

    void Awake()
    {
        Instance = this;
    }

    void Play(AudioClip clip)
    {
        if (clip == null) return;

        sfxSource.Stop();
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    public void PlaySelect()
    {
        Play(selectSound);
    }

    public void PlayPanel()
    {
        Play(panelOpenSound);
    }

    public void PlayClick()
    {
        Play(clickSound);
    }
}