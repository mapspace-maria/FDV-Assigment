using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnstroautaPool : MonoBehaviour
{

    public GameObject tilePrefab;
    public int poolSize = 5;
    public float spawnTiming = 3f;
    

    private GameObject[] tilesArray;
    private int currentTile = 0;
    private Vector2 objectPoolPosition = new Vector2(13, 5);

    private float spawnXPosition = 13f;

    private void Start()
    {
        tilesArray = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            tilesArray[i] = Instantiate(tilePrefab, objectPoolPosition, Quaternion.identity);
            tilesArray[i].SetActive(false);
        }
        
        InvokeRepeating(nameof(SpawnTiles), 0, spawnTiming);
    }
    
    private void SpawnTiles()
    {

        tilesArray[currentTile].SetActive(true);
        tilesArray[currentTile].transform.position = new Vector2(spawnXPosition, 0);

    }
}
