using UnityEngine;

public class ResourcesLogic : MonoBehaviour
{
    [SerializeField] private Balance _balanceData;

    private int _respurces;

    private void Start()
    {
        _respurces = _balanceData.startPlayerResources;
    }

    public int Resources => _respurces;

    private void OnEnable()
    {
        BuyLogic.onResourceAdded += AddResources;
        SellLogic.onResourceDeducted += DeductedResources;
    }

    private void OnDisable()
    {
        BuyLogic.onResourceAdded -= AddResources;
        SellLogic.onResourceDeducted -= DeductedResources;
    }

    private void AddResources()
    {
        _respurces++;
    }

    private void DeductedResources()
    {
        _respurces--;
    }
}
