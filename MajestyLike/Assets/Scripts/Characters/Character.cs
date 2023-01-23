using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IDamageable<int>, IKillable
{
    [SerializeField] private string name;
    [SerializeField] private Char_Class charClass;
    [SerializeField] private GameObject charModel;

    public void Die()
    {
        throw new System.NotImplementedException();
    }

    public void TakeDamage(int takenDamage)
    {
        throw new System.NotImplementedException();
    }
}
