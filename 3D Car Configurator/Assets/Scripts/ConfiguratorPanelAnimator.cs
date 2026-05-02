using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class ConfiguratorPanelAnimator : MonoBehaviour
{
    public RectTransform panel;
    public float duration = 0.3f;

    CanvasGroup cg;

    Vector3 shownScale = Vector3.one;
    Vector3 hiddenScale = Vector3.zero;

    void Awake()
    {
        cg = GetComponent<CanvasGroup>();
        panel = GetComponent<RectTransform>();

        panel.localScale = hiddenScale;
        cg.alpha = 0;

        gameObject.SetActive(false);
    }

    public void Show()
    {
        SoundManager.Instance.PlayPanel();  
        gameObject.SetActive(true);

        panel.DOKill();
        cg.DOKill();

        panel.localScale = hiddenScale;
        cg.alpha = 0;

        cg.DOFade(1, duration);
        panel.DOScale(shownScale, duration).SetEase(Ease.OutBack);
    }

    public void Hide()
    {
        panel.DOKill();
        cg.DOKill();

        cg.DOFade(0, duration);
        panel.DOScale(hiddenScale, duration)
            .SetEase(Ease.InBack)
            .OnComplete(() => gameObject.SetActive(false));
    }
}