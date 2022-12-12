using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageContainer : MonoBehaviour
{
    [SerializeField] private Button _cancelButton;
    [SerializeField] private RectTransform _container;
    [SerializeField] private CanvasGroup _group;

    private List<Page> _pages = new List<Page>();

    private void Awake()
    {
        HideAllPages();
        _cancelButton.onClick.AddListener(OnCancelButtonClick);
    }

    private void OnCancelButtonClick()
    {
        HideAllPages();
    }

    public void AddPage(Page page)
    {
        _pages.Add(page);
        page.transform.SetParent(_container, false);
    }

    public void ShowPage(Page page)
    {
        HideAllPages();
        page.Show();
        _group.SwitchState(true);
    }

    public void HideAllPages()
    {
        _group.SwitchState(false);
        foreach (var page in _pages)
            page.Hide();
    }
}