using UnityEngine;
using Zenject;

public class CurrentPriceInstaller : MonoInstaller
{
    [SerializeField] private CurrentPriceLogic _currentPriceLogic;

    public override void InstallBindings()
    {
        Container.Bind<CurrentPriceLogic>().FromInstance(_currentPriceLogic);
    }
}