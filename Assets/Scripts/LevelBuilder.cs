using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    public GameObject[] platforms;
    public int levelLength = 10;
    public float platformInterval = 5.0f;
    private float yPos;
    public GameObject parentLevel;

    void Start()
    {
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
        GameObject newPlatform = Instantiate(platforms[index], new Vector3(transform.position.x, yPos, transform.position.z), Quaternion.identity);
        yPos -= platformInterval;
        newPlatform.transform.SetParent(parentLevel.transform);
    }
}
