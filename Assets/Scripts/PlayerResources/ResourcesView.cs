using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class ResourcesView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private ResourcesLogic _resourcesLogic;
    [Inject]
    private void Cunstruct(ResourcesLogic resourcesLogic)
    {
        _resourcesLogic = resourcesLogic;
    }

    private void Update()
    {
        _text.SetText(_resourcesLogic.Resources.ToString());
    }
}
