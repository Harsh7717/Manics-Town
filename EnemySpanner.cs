using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanner : MonoBehaviour
{
    public Terrain terrain;
    public int numberOfEnemies;
    private int currentObjects; 
    private int terrainWidth; 
    private int terrainLength; 
    private int terrainPosX; 
    private int terrainPosZ;

    int enemyno;
    public GameObject[] Enemies;

    float timer;
    public float delay_timer = 0.5f;
    void Start()
    {
       
        terrainWidth = (int)terrain.terrainData.size.x;
        
        terrainLength = (int)terrain.terrainData.size.z;
       
        terrainPosX = (int)terrain.transform.position.x;
        
        terrainPosZ = (int)terrain.transform.position.z;

        timer = delay_timer;
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            if (currentObjects <= numberOfEnemies)
            {
                enemyno = Random.Range(0, 11);
              
                int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
               
                int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
              
                float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
               
                GameObject newObject = (GameObject)Instantiate(Enemies[enemyno], new Vector3(posx, posy, posz), Quaternion.identity);
                currentObjects += 1;
                timer = delay_timer;
            }
        }

    }
}
