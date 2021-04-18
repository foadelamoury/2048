using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell2048 : MonoBehaviour
{
    
    public Cell2048 right;
    public Cell2048 left;
    public Cell2048 up;
    public Cell2048 down;

    public Fill2048 fill;
    
        private void OnEnable()
        {
            
            GameController2048.slide += OnSlide;
        }
        private void OnDisable()
        {
            GameController2048.slide -= OnSlide;
        }
        private void OnSlide(string whatWasSent)
        {
            Debug.Log(whatWasSent);
            if (whatWasSent == "w")
            {
                if (up != null) return;

                Cell2048 currenCell = this;
                SlideUp(currenCell);
                
                // this code is for sliding the squares that have numbers.

            }
            if (whatWasSent == "d")
            {
                
            }
            if (whatWasSent == "s")
            {
                
            }
            if (whatWasSent == "a")
            {
                
            }

        }

        void SlideUp(Cell2048 currentCell)
        {
            if (currentCell.down == null)
                return;
            Debug.Log(currentCell.gameObject);
            if (currentCell.fill != null)
            {
                Cell2048 nextCell = currentCell.down;
                while (nextCell.down != null || nextCell.fill == null)
                {
                    nextCell = nextCell.down;
                }

                if (nextCell.fill != null)
                {
                    if (currentCell.fill.value == nextCell.fill.value)
                    {
                        Debug.Log("doubled");
                        nextCell.fill.transform.parent = currentCell.transform;
                    }
                    else
                    {
                        Debug.Log("!doubled");
                        nextCell.fill.transform.parent = currentCell.down.transform;

                    }
                }
            }
            

            else
            {
                Cell2048 nextCell = currentCell.down;
                while (nextCell.down != null || nextCell.fill == null)
                {
                    nextCell = nextCell.down;
                }

                if (nextCell.fill != null)
                {
                    nextCell.fill.transform.parent = currentCell.transform;
                    SlideUp(currentCell);
                    Debug.Log("Slide to empty");
                }
            }
            
            if (currentCell.down == null) return;
            SlideUp(currentCell.down);
        }
}
