using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _unitPrefab;
    [SerializeField] public Transform _spawnPoint;
    [SerializeField] public Transform _exitPoint;
    private GameObject _unit;
    

    private void Start()
    {
        _unit = Instantiate(_unitPrefab, _spawnPoint.position, Quaternion.identity);
        _unit.GetComponent<PeasantBase>().SetStarterPoints(_spawnPoint, _exitPoint);
    }

    
}
