using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandColumn : MonoBehaviour
{
    //Initialize variables
       public GameObject columnPrefab;
        public int randColumnSize = 5;

       public float spawnRate = 3f;
       public float columnMin = -1f;
       public float columnMax = 3.5f;

        private GameObject[] columns;

       private int currColumn = 0;
       private Vector2 objectRandPosition = new Vector2(-15, -25);

        private float spawnXPosition = 10f;
        private float respawnTime;




    // Start is called before the first frame update
    void Start()
    {
        respawnTime = 0;

        //Initalize columns collection
        columns = new GameObject[randColumnSize];

        for (int i = 0; i < randColumnSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectRandPosition, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        respawnTime = respawnTime + Time.deltaTime;

        if (GameController.instance.gameOver == false && respawnTime >= spawnRate)
        {
            respawnTime = 0f;

            //Set random y position for columns
            float spawnYPosition = Random.Range(columnMin, columnMax);

            //set column to respective position
            columns[currColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            
            //Increase currColumn value and if the size value is too big, sets it to initial value of 0
            currColumn++;

            if (currColumn >= randColumnSize)
            {
                currColumn = 0;
            }
        }
    }
}
