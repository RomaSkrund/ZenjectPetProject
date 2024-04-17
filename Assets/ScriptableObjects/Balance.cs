using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BalanceData", menuName = "Balance/BalanceSettings")]
public class Balance : ScriptableObject
{
    [SerializeField] private int _target;
    [SerializeField] private int _startPlayerBalance;
    [SerializeField] private int _startPlayerResources;

    public int target => _target;
    public int startPlayerBalance => _startPlayerBalance;
    public int startPlayerResources => _startPlayerResources;

    [SerializeField, Min(0)] private int _currentPrice;
    [SerializeField, Min(0)] private int _minPrice;
    [SerializeField, Min(1)] private int _maxPrice;
    [SerializeField] private float _timeChangePrice;
    [SerializeField] private int _stepChangePrice;

    public int currentPrice => _currentPrice;
    public int minPrice => _minPrice;
    public int maxPrice => _maxPrice;
    public float timeChangePrice => _timeChangePrice;
    public int stepChangePrice => _stepChangePrice;
}
