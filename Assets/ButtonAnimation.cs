using UnityEngine;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
    public RectTransform _rectTransform;

    public void Normal()
    {
        _rectTransform.DOScale(1, .15f);
    }

    public void Hover()
    {
        _rectTransform.DOScale(1.2f, 0.15f);
    }

    public void Pressed()
    {
        _rectTransform.DOScale(1.1f, 0.15f);
    }
}
