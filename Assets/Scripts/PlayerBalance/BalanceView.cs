using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class BalanceView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private BalanceLogic _balanceLogic;
    [Inject]
    private void Construct(BalanceLogic balanceLogic)
    {
        _balanceLogic = balanceLogic;
        Debug.Log(_balanceLogic.PlayerBalance);
    }

    private void Update()
    {
        _text.SetText(_balanceLogic.PlayerBalance.ToString());
    }
}
