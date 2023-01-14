using UnityEngine;

[CreateAssetMenu(fileName = "Hero_Character", menuName = "Character/Hero Character")]
public class Hero_Char : ScriptableObject
{
    public string Name;
    public int BaseHP;
    public int BaseDamage;
    public int WeaponLevel;
    public int ArmorLevel;
}
