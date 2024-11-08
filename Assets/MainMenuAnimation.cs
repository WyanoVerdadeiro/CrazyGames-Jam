using DG.Tweening;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{
    
    [SerializeField]
    private RectTransform _logo;
    [SerializeField]
    private RectTransform _soundBar;
    [SerializeField]
    private RectTransform _playButton;
    [SerializeField]
    private RectTransform _howToPlayButton;
    [SerializeField]
    private RectTransform _creditsButton;
    [SerializeField]
    private RectTransform _credits;
    [SerializeField]
    private RectTransform _rightBottomAnchor;
    [SerializeField]
    private CanvasGroup[] _buttons;
    [SerializeField]
    private RectTransform _howToPlay;
    [SerializeField]
    private CanvasGroup _returnButton;

    private void Start()
    {
        ResetMainMenu();
        OpenMainMenu();
    }

    private void ResetMainMenu()
    {
        _logo.localScale = Vector3.zero;
        _soundBar.localScale = Vector3.zero;
        _playButton.localScale = Vector3.zero;
        _howToPlayButton.localScale = Vector3.zero;
        _creditsButton.localScale = Vector3.zero;
        _credits.localPosition = new Vector2(-195, -350);
        foreach (CanvasGroup button in _buttons)
        {
            button.interactable = false;
            button.blocksRaycasts = false;
        }
    }


    public void OpenMainMenu()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(_logo.DOScale(1, 0.3f));
        sequence.AppendInterval(0.5f);
        sequence.Append(_playButton.DOScale(1, 0.15f));
        sequence.Append(_soundBar.DOScale(1, 0.15f));
        sequence.Append(_rightBottomAnchor.DOScale(1, 0.15f));
        sequence.Append(_howToPlayButton.DOScale(1, 0.15f));
        sequence.Append(_creditsButton.DOScale(1, 0.15f));
        sequence.AppendCallback(() => {
            for (int i = 0; i < 5; i++)
            {
                _buttons[i].interactable = true;
                _buttons[i].blocksRaycasts = true;
            }
        });
    }

    public void CloseMainMenu()
    {
        foreach (CanvasGroup button in _buttons)
        {
            button.interactable = false;
            button.blocksRaycasts = false;
        }
        _logo.DOScale(0, 0.3f);
        _playButton.DOScale(0, 0.15f);
        _soundBar.DOScale(0, 0.15f);
        _howToPlayButton.DOScale(0, 0.15f);
        _creditsButton.DOScale(0, 0.15f);
        _howToPlayButton.DOAnchorPos(new Vector2(120.5f, -43), 0.3f);
        _credits.DOAnchorPos(new Vector2(303, -393), 0.3f);
        _rightBottomAnchor.DOScale(0, 0.15f);
    }

    public void OpenCredits()
    {
        _buttons[4].interactable = false;
        _buttons[4].blocksRaycasts= false;
        _howToPlayButton.DOAnchorPos(new Vector2(-59, -43), 0.3f);
        _creditsButton.DOScale(0, 0.1f);
        _credits.DOAnchorPos(new Vector3(303, 147f), 0.3f).OnComplete(() =>
        {
            _buttons[5].interactable = true;
            _buttons[5].blocksRaycasts = true;
        });

    }

    public void CloseCredits()
    {
        _buttons[5].interactable = false;
        _buttons[5].blocksRaycasts = false;
        _howToPlayButton.DOAnchorPos(new Vector2(120.5f, -43), 0.3f);
        _credits.DOAnchorPos(new Vector2(303, -393), 0.3f);
        _creditsButton.DOScale(1, 0.1f).OnComplete(() =>
        {
            _buttons[4].interactable = true;
            _buttons[4].blocksRaycasts = true;
        });
    }

    public void OpenHowToPlay()
    {
        var sequence = DOTween.Sequence();

        sequence.AppendCallback(CloseMainMenu);
        sequence.AppendInterval(0.5f);
        sequence.Append(_howToPlay.DOScale(1, 0.3f));
        sequence.OnComplete(() =>
        {
            _returnButton.interactable = true;
            _returnButton.blocksRaycasts = true;
        });
    }

    public void CloseHowToPlay()
    {
        _returnButton.interactable = true;
        _returnButton.blocksRaycasts = true;

        var sequence = DOTween.Sequence();

        sequence.Append(_howToPlay.DOScale(0, 0.3f));
        sequence.AppendCallback(OpenMainMenu);
    }

}
