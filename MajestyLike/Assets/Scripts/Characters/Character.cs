using UnityEngine;

public class Character : MonoBehaviour, IDamageable<int>, IKillable
{
    public enum CharType
    {
        Nonfight,
        Fight,
        Hero
    }

    [SerializeField] private string name;
    [SerializeField] private Char_Class charClass;
    [SerializeField] private GameObject charModel;
    [SerializeField] private int hpMultiplier;
    [SerializeField] private CharType charType;
    [SerializeField] private Animator animator;


    private int strength;
    private int intelligence;
    private int willpower;
    private int agility;
    private int endurance;
    private int luck;
    private int hp;
    private int currentHP;
    

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

    private void Start()
    {
        SetCurrentHP();
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

    private void SetCurrentHP()
    {
        currentHP = hp;
    }
}
