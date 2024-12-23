using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    public int ruchy = 0;
    public GameObject  frog;
    public SpriteRenderer froge;
    public Sprite up;
    public Sprite left;
    public Sprite right;
    public Sprite down;
   
    void Start()
    {
        

    }
    void Update()
    {
        // Debug.Log(ruchy);
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            ruchy++;
            froge.sprite = up;
            frog.transform.position += new Vector3(0, 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            ruchy++;
            froge.sprite = down;
            frog.transform.position += new Vector3(0, -1, 0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ruchy++;
            froge.sprite = left;
            frog.transform.position += new Vector3(-1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            ruchy++;
            froge.sprite = right;
            frog.transform.position += new Vector3(1, 0, 0);
        }






    }
}
