using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowInfo : MonoBehaviour
{
    [SerializeField] private House house;
    [SerializeField] private GameObject testInfoPlate;
    [SerializeField] private TextMeshProUGUI testText;

    private void OnMouseDown()
    {
        testInfoPlate.SetActive(true);
        UpdateInfoText();
    }

    public void UpdateInfoText()
    {
        if (testInfoPlate.activeSelf)
        {
            testText.text = "Gold " + house.GetCurrentGold();
        }
    }
}
