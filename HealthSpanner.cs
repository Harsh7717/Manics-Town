using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpanner : MonoBehaviour
{
    public Terrain terrain;
    public int numberOfPickups; 
    private int currentObjects; 
    private int terrainWidth;
    private int terrainLength; 
    private int terrainPosX; 
    private int terrainPosZ;

    int pickupno;
    public GameObject[] Pickups;

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
            if (currentObjects <= numberOfPickups)
            {
                pickupno = Random.Range(0, 2);
               
                int posx = Random.Range(terrainPosX, terrainPosX + terrainWidth);
               
                int posz = Random.Range(terrainPosZ, terrainPosZ + terrainLength);
              
                float posy = Terrain.activeTerrain.SampleHeight(new Vector3(posx, 0, posz));
                
                GameObject newObject = (GameObject)Instantiate(Pickups[pickupno], new Vector3(posx, posy, posz), Quaternion.identity);
                currentObjects += 1;
                timer = delay_timer;
            }
        }

    }
}
