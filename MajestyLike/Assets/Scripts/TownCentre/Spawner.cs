using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _unitPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _exitPoint;
    private GameObject _unit;
    public float speed = 1.0f;

    private void Start()
    {
        _unit = Instantiate(_unitPrefab, _spawnPoint.position, Quaternion.identity);
    }

    private void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        
        _unit.transform.position = Vector3.MoveTowards(_unit.transform.position, _exitPoint.position, step);
    }
}
