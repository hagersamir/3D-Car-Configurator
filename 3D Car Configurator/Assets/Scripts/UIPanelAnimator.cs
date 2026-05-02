using UnityEngine;
using DG.Tweening;

public class UIPanelAnimator : MonoBehaviour
{
    public RectTransform panel;
    public float duration = 0.25f;

    Vector2 hidden = new Vector2(800, 0);
    Vector2 shown = Vector2.zero;

    void Awake()
{
    panel.gameObject.SetActive(true);
    panel.anchoredPosition = hidden;
}

    public void Show()
{
    SoundManager.Instance.PlayPanel();
    gameObject.SetActive(true);
    panel.DOKill(); //  stop previous animations
    panel.DOAnchorPos(shown, duration).SetEase(Ease.OutBack);
}

public void Hide()
{
    panel.DOKill(); 

    panel.DOAnchorPos(hidden, duration)
        .SetEase(Ease.InBack)
        .OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
}
}