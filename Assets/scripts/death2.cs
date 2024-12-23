using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death2 : MonoBehaviour
{
    public GameObject cel;
    public GameObject gracz;
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
        if(other.CompareTag("barier"))
        {
            
            gracz.transform.position = cel.transform.position;
        }
    }
}
