using DG.Tweening;
using System.Buffers;
using UnityEngine;

public class GameOverAnimation : MonoBehaviour
{
    [SerializeField]
    private RectTransform _title;
    [SerializeField]
    private RectTransform _playAgainButton;
    [SerializeField]
    private RectTransform _exitGameButton;
    [SerializeField]
    private CanvasGroup[] canvasGroups;

    private void Start()
    {
        foreach (var group in canvasGroups) 
        {
            group.interactable = false;
            group.blocksRaycasts = false;
        }
        _title.localScale = Vector3.zero;
        _playAgainButton.localScale = Vector3.zero;
        _exitGameButton.localScale = Vector3.zero;
    }

    private void OnEnable()
    {
        OpenGameOverMenu();
    }

    public void OpenGameOverMenu()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(_title.DOScale(1, .15f));
        sequence.AppendInterval(.25f);
        sequence.Append(_playAgainButton.DOScale(1, .15f));
        sequence.Append(_exitGameButton.DOScale(1, .15f));
        sequence.OnComplete(() =>
        {
            foreach (var group in canvasGroups)
            {
                group.interactable = true;
                group.blocksRaycasts = true;
            }
        });
    }

    public void CloseGameOverMenu()
    {
        foreach (var group in canvasGroups)
        {
            group.interactable = false;
            group.blocksRaycasts = false;
        }

        _title.DOScale(1, .15f);
        _playAgainButton.DOScale(1, .15f);
        _exitGameButton.DOScale(1, .15f);
    }
}
