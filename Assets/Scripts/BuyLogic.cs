using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using System;

public class BuyLogic : MonoBehaviour
{
    public static Action onResourceAdded;
    public static Action<int> onBalanceDeducted;

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

    private void Update()
    {
        _playerBalance = _balanceLogic.PlayerBalance;
    }

    public void BuyingResours()
    {
        if (_playerBalance >= _currentPriceLogic.CurrentPrice)
        {
            _playerBalance -= _currentPriceLogic.CurrentPrice;

            onResourceAdded?.Invoke();
            onBalanceDeducted?.Invoke(_playerBalance);
        }
    }
}
