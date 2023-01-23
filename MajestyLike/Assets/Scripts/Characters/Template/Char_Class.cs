using UnityEngine;

[CreateAssetMenu(fileName = "New character class", menuName = "Character class")]
public class Char_Class : ScriptableObject
{
    public string Class_name;
    public int Strength;
    public int Intelligence;
    public int Willpower;
    public int Agility;
    public int Endurance;
    public int Luck;
}
