using TMPro;
using UnityEngine;

public class SetTarget : MonoBehaviour
{
    [SerializeField] private Balance _balanceData;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        _text.SetText(_balanceData.target.ToString());
    }

}
