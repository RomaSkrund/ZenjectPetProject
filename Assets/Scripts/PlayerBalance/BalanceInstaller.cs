using UnityEngine;
using Zenject;

public class BalanceInstaller : MonoInstaller
{
    [SerializeField] private BalanceLogic _balanceLogic;

    public override void InstallBindings()
    {
        Container.Bind<BalanceLogic>().FromInstance(_balanceLogic);
    }
}