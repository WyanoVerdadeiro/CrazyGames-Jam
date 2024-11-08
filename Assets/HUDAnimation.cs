using UnityEngine;
using DG.Tweening;

public class HUDAnimation : MonoBehaviour
{
    [SerializeField]
    private RectTransform[] _uiElements;
    [SerializeField] 
    private RectTransform _remixTitle;
    [SerializeField]
    private RectTransform[] _remixBlocks;

    // Update is called once per frame
    private void Start()
    {
        foreach (RectTransform uiElement in _uiElements)
        {
            uiElement.localScale = Vector3.zero;
        }
        _remixTitle.localScale = Vector3.zero;

        foreach (RectTransform remixBlock in _remixBlocks)
        {
            remixBlock.localScale = Vector3.zero;
        }
        //OpenHUDMenu();
    }

    public void OpenHUDMenu()
    {
        var sequence = DOTween.Sequence();

        foreach (RectTransform uiElement in _uiElements)
        {
            sequence.Append(uiElement.DOScale(1, .15f));
        }
    }

    public void OpenRemixMenu()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(_remixTitle.DOScale(1, 0.15f));
        foreach (RectTransform remixBlock in _remixBlocks)
        {
            sequence.Append(remixBlock.DOScale(1, .1f));
        }
        sequence.AppendInterval(1.5f);
        sequence.AppendCallback(CloseRemixMenu);
    }

    public void CloseRemixMenu()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(_remixTitle.DOScale(0, 0.15f));
        foreach (RectTransform remixBlock in _remixBlocks)
        {
            sequence.Append(remixBlock.DOScale(0, .1f));
        }
    }
}
