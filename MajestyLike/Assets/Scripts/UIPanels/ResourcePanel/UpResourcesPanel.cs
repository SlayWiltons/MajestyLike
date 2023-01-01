using UnityEngine;
using TMPro;

public class UpResourcesPanel : MonoBehaviour
{
    [SerializeField] private Resource resource;
    [SerializeField] private TextMeshProUGUI resName;
    [SerializeField] private TextMeshProUGUI resValue;

    private void Start()
    {
        resName.text = resource.Name;
        UpdateResInfo(resource.Count);
    }

    private void UpdateResInfo(int _newResValue)
    {
        resValue.text = _newResValue.ToString();
    }
}
