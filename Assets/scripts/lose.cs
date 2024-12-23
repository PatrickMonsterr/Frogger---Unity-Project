using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    public movement ruch;
    

    
    void Start()
    {
        
        StartCoroutine(WaitAndChangeScene());
    }

    
    IEnumerator WaitAndChangeScene()
    {
        Debug.Log($"RUCHY RUCHY{ruch.ruchy}");
        yield return new WaitForSeconds(3);

        
        SceneManager.LoadSceneAsync(0);
    }
}
