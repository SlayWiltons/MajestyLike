using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable<int>, IKillable
{
    public enum CharType
    {
        Nonfight,
        Fight
    }

    [SerializeField] private string name;
    [SerializeField] private Char_Class charClass;
    [SerializeField] private GameObject charModel;
    [SerializeField] private int hpMultiplier;
    [SerializeField] private CharType charType;


    private int strength;
    private int intelligence;
    private int willpower;
    private int agility;
    private int endurance;
    private int luck;
    private int hp;
    

    private void Awake()
    {
        if (charClass != null)
        {
            strength = charClass.Strength;
            intelligence = charClass.Intelligence;
            willpower = charClass.Willpower;
            agility = charClass.Agility;
            endurance = charClass.Endurance;
            luck = charClass.Luck;
            SetHP();
        }
    }

    public void Die()
    {
        charModel.SetActive(false);
    }

    public void TakeDamage(int takenDamage)
    {
        if (takenDamage < hp)
        {
            hp -= takenDamage;
        }
        else
        {
            Die();
        }
    }

    private void SetHP()
    {
        hp = hpMultiplier * endurance;
    }
}
