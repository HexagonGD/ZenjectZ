using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class Page : MonoBehaviour
{
    [SerializeField] private CanvasGroup _group;
    [SerializeField] private Image _background;
    [SerializeField] private Text _header;
    [SerializeField] private Text _body;

    public void SetInfo(PageInfoConfig.PageInfo info)
    {
        _background.color = info.Color;
        _header.text = info.Header;
        _body.text = info.Body;
    }

    public void Show()
    {
        _group.SwitchState(true);
    }

    public void Hide()
    {
        _group.SwitchState(false);
    }

    public class Factory : PlaceholderFactory<Page> { }
}