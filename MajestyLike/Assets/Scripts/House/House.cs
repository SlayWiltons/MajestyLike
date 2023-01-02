using UnityEngine;
using ResourceCalc;

public class House : MonoBehaviour
{
    [SerializeField] private int goldToAdd;
    [SerializeField] private float timeBeforeAdd;
    [SerializeField] private ShowInfo testInfo;
    private int currentGold;

    private void Start()
    {
        currentGold = 0;
        InvokeRepeating("AddGold", timeBeforeAdd, timeBeforeAdd);
    }

    private void AddGold()
    {
        currentGold = ResourceCalculator.ResPlus(currentGold, goldToAdd);
        Debug.Log(currentGold);
        testInfo.UpdateInfoText();
    }

    public int GetCurrentGold()
    {
        return currentGold;
    }
}
