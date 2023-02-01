using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    public GameObject[] platforms;
    public float platformInterval = 5.0f;
    private float _yPos;
    public GameObject parentLevel;
    public int levelLength;

    void Start()
    {
        levelLength = Random.Range(10, 30);
        for (int i = 0; i < levelLength; i++)
        {
            if (i == 0)
            {
                SpawnPlatform(0);
            }
            else
            {
                SpawnPlatform(Random.Range(1, platforms.Length - 2));
            }
        }
            SpawnPlatform(platforms.Length - 1);
    }

    void SpawnPlatform(int index)
    {
        GameObject newPlatform = Instantiate(platforms[index], new Vector3(transform.position.x, _yPos, transform.position.z), Quaternion.identity);
        _yPos -= platformInterval;
        newPlatform.transform.SetParent(parentLevel.transform);
    }
}
