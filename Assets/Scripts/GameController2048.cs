using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController2048 : MonoBehaviour
{
    [SerializeField] GameObject fillPrefab;
    [SerializeField] Transform[] allCells;
    public static int countCellsFilled=0;
    public static Action<string> slide;

    // Start is called before the first frame update
    void Start()
    {
        if (countCellsFilled<16)
        {
            InvokeRepeating("SpawnFill", 2.0f, 0.3f);

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnFill();
        }

        if (Input.GetKeyDown((KeyCode.W)))
        {
            slide("w");
        }
        if (Input.GetKeyDown((KeyCode.D)))
        {
            slide("d");

        }
        if (Input.GetKeyDown((KeyCode.S)))
        {
            slide("s");

        }
        if (Input.GetKeyDown((KeyCode.A)))
        {
            slide("a");

        }
    }

    public void SpawnFill()
    {    
        int whichSpawn = UnityEngine.Random.Range(0, allCells.Length);
        if (allCells[whichSpawn].childCount !=0)
        {
            countCellsFilled++;
            if (countCellsFilled < 16)
            {
                SpawnFill();
            

            // Debug.Log(allCells[whichSpawn].name + " is already filled"); to insure that the cell is filled 
            }
            return;
        }
        float chance = UnityEngine.Random.Range(0f, 1f);
        Debug.Log(chance);
        if (chance < .2f)
        {
            return;
        }
        else if (chance < .8f)
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            // Debug.Log(2);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            allCells[whichSpawn].GetComponent <Cell2048>().fill = tempFillComp;
            // tempFillComp.FillValueUpdate(2);
        }
        else
        {
            GameObject tempFill = Instantiate(fillPrefab, allCells[whichSpawn]);
            // Debug.Log(4);
            Fill2048 tempFillComp = tempFill.GetComponent<Fill2048>();
            allCells[whichSpawn].GetComponent <Cell2048>().fill = tempFillComp;
            // tempFillComp.FillValueUpdate(4);


        }

       
    }
}
