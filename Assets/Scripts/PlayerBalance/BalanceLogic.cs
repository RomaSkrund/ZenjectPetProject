using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BalanceLogic : MonoBehaviour
{
    [SerializeField] private Balance _balanceData;

    private int _playerBalance;

    private void Start()
    {
        _playerBalance = _balanceData.startPlayerBalance;
    }
    public int PlayerBalance => _playerBalance;

    private void OnEnable()
    {
        BuyLogic.onBalanceDeducted += BalanceChange;
        SellLogic.onBalanceAdded += BalanceChange;
    }

    private void OnDisable()
    {
        BuyLogic.onBalanceDeducted -= BalanceChange;
        SellLogic.onBalanceAdded += BalanceChange;
    }

    private void BalanceChange(int newBalance)
    {
        _playerBalance = newBalance;
    }

}
