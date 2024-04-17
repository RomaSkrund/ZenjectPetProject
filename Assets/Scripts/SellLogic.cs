using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SellLogic : MonoBehaviour
{
    public static Action onResourceDeducted;
    public static Action<int> onBalanceAdded;

    private int _playerBalance;

    private CurrentPriceLogic _currentPriceLogic;
    [Inject]
    private void Construct(CurrentPriceLogic currentPriceLogic)
    {
        _currentPriceLogic = currentPriceLogic;
    }

    private BalanceLogic _balanceLogic;
    [Inject]
    private void Construct(BalanceLogic balanceLogic)
    {
        _balanceLogic = balanceLogic;
    }

    private ResourcesLogic _resourcesLogic;
    [Inject]
    private void Construct(ResourcesLogic resourcesLogic)
    {
        _resourcesLogic = resourcesLogic;
    }

    private void Update()
    {
        _playerBalance = _balanceLogic.PlayerBalance;
    }

    public void SellingResours()
    {
        if (_resourcesLogic.Resources > 0)
        {
            _playerBalance += _currentPriceLogic.CurrentPrice;

            onResourceDeducted?.Invoke();
            onBalanceAdded?.Invoke(_playerBalance);
        }
    }
}
