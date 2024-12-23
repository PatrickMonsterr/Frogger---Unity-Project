using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_teleport : MonoBehaviour
{
    public GameObject cel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("auto"))
        {
           
            other.transform.position = cel.transform.position;
        }
    }
}
