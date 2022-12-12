using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class AppInstaller : MonoInstaller
{
    [SerializeField] private Menu _menu;
    [SerializeField] private PageContainer _container;
    [SerializeField] private Page _pagePrefab;
    [SerializeField] private Button _buttonPrefab;

    public override void InstallBindings()
    {
        Container.BindFactory<Page, Page.Factory>()
            .FromComponentInNewPrefab(_pagePrefab)
            .WithGameObjectName("Page");

        Container.BindFactory<Button, PageButton.Factory>()
            .FromComponentInNewPrefab(_buttonPrefab)
            .WithGameObjectName("PageButton");

        Container.Bind<Menu>().FromInstance(_menu).AsSingle();
        Container.Bind<UIController>().AsSingle().NonLazy();
        Container.Bind<PageContainer>().FromComponentInNewPrefab(_container).AsSingle();
    }
}