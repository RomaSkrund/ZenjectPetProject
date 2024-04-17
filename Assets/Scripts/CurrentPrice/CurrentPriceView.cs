using TMPro;
using UnityEngine;
using Zenject;

public class CurrentPriceView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private CurrentPriceLogic _currentPriceLogic;
    [Inject]
    private void Construct(CurrentPriceLogic currentPriceLogic)
    {
        _currentPriceLogic = currentPriceLogic;
    }

    private void Update()
    {
        _text.SetText(_currentPriceLogic.CurrentPrice.ToString());
    }
}
