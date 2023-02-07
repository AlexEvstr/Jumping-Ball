using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefabPlatforms;
    private GameObject _parentLevel;

    private Queue<RingController> _ringControllers;

    private float _intervalSpawnPlatforms;
    private float _yPosition;
    private int _levelLength;

    public int LevelLength => _levelLength;

    private void Awake()
    {
        _parentLevel = gameObject;
        _intervalSpawnPlatforms = 5.0f;
        _levelLength = Random.Range(5, 20);
        _ringControllers = new Queue<RingController>();

        SpawnPlatform(0);
        for (int i = 1; i < _levelLength; i++)
        {
            SpawnPlatform(Random.Range(1, _prefabPlatforms.Length - 1));
        }
        SpawnPlatform(_prefabPlatforms.Length - 1);
    }

    private void SpawnPlatform(int index)
    {
        GameObject platform = Instantiate(
            _prefabPlatforms[index], 
            new Vector3(transform.position.x, _yPosition, transform.position.z), 
            Quaternion.identity);

        _yPosition -= _intervalSpawnPlatforms;
        platform.transform.SetParent(_parentLevel.transform);
        _ringControllers.Enqueue(platform.transform.GetChild(0).GetComponent<RingController>());
    }

    public RingController GetActiveRing()
    {
        return _ringControllers.Dequeue();
    }
}