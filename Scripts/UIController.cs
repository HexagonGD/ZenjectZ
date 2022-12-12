using UnityEngine.SceneManagement;
using Zenject;

public class UIController
{
    private Scene _UIScene;

    [Inject]
    public UIController(Menu menu, PageContainer container, Page.Factory pageFactory,
        PageButton.Factory pageButtonFactory, PageInfoConfig config)
    {
        _UIScene = SceneManager.CreateScene("UIScene");
        SceneManager.MoveGameObjectToScene(container.gameObject, _UIScene);

        foreach(var info in config.Pages)
        {
            var page = pageFactory.Create();
            page.SetInfo(info);
            container.AddPage(page);

            var button = pageButtonFactory.Create();
            button.onClick.AddListener(() => container.ShowPage(page));

            menu.AddButton(button);
        }
    }
}