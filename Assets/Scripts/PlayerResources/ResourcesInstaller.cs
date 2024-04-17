using UnityEngine;
using Zenject;

public class ResourcesInstaller : MonoInstaller
{
    [SerializeField] private ResourcesLogic _resourcesLogic;
    public override void InstallBindings()
    {
        Container.Bind<ResourcesLogic>().FromInstance(_resourcesLogic);
    }
}