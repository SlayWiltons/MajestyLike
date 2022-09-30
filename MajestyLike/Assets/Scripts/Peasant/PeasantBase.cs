using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantBase : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform _spawnPoint;
    private Transform _exitPoint;
    


    private void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, _exitPoint.position, step);
    }

    public void SetStarterPoints(Transform innerPoint, Transform outerPoint)
    {
        _spawnPoint = innerPoint;
        _exitPoint = outerPoint;
    }
}
