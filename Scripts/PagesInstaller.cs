using UnityEngine;
using Zenject;

[CreateAssetMenu(menuName = "ZenjectZ/PagesInstaller")]
public class PagesInstaller : ScriptableObjectInstaller<PagesInstaller>
{
    [SerializeField] private PageInfoConfig _config;

    public override void InstallBindings()
    {
        Container.BindInstance(_config);
    }
}