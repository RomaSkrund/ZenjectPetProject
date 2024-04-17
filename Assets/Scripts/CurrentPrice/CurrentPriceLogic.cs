using System.Collections;
using TMPro;
using UnityEngine;
using Zenject;

public class CurrentPriceLogic : MonoBehaviour
{
    [SerializeField] private Balance _balance;

    private int _currentPrice;

    public int CurrentPrice => _currentPrice;

    private void Start()
    {
        _currentPrice = _balance.currentPrice;
        StartCoroutine(ChangePrice());
    }

    IEnumerator ChangePrice()
    {
        while (true)
        {
            int sign = Random.Range(0, 2);

            switch (sign)
            {
                case 0:
                    if (_currentPrice - _balance.stepChangePrice >= _balance.minPrice)
                    {
                        _currentPrice -= _balance.stepChangePrice;
                    }
                    else
                    {
                        _currentPrice = _balance.minPrice;
                    }
                    break;
                case 1:
                    if (_currentPrice + _balance.stepChangePrice <= _balance.maxPrice)
                    {
                        _currentPrice += _balance.stepChangePrice;
                    }
                    else
                    {
                        _currentPrice = _balance.maxPrice;
                    }
                    break;
            }
            yield return new WaitForSeconds(_balance.timeChangePrice);
        }
    }
}
