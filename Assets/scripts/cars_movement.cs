using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_movement : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Auto_jazda());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Auto_jazda()
    {
        while (true)
        {
            car.transform.position += new Vector3(1, 0, 0);
            yield return new WaitForSeconds(0.5f);
        }

    }
}
