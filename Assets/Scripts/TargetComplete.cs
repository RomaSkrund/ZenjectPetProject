using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TargetComplete : MonoBehaviour
{
    [SerializeField] private Balance _balanceData;
    [SerializeField] private GameObject _winGroup;

    private BalanceLogic _balanceLogic;
    [Inject]
    private void Construct(BalanceLogic balanceLogic)
    {
        _balanceLogic = balanceLogic;
    }

    private void IsTargetComplete()
    {
        if (_balanceLogic.PlayerBalance >= _balanceData.target)
        {
            _winGroup.SetActive(true);
        }
    }

    private void Update()
    {
        IsTargetComplete();
    }
}
