using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class death : MonoBehaviour
{
    public GameObject LOST;

    public GameObject[] zycia_zaby;

    int lives = 0;
    //public TMP_Text zycia;

    public GameObject cel;
    public GameObject gracz;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zycia.text = $"Lives:{lives}";

        if (lives == 3)
        {
            LOST.SetActive(true);
            StartCoroutine(WaitAndChangeScene());

        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("auto"))
        {
            
                zycia_zaby[lives].SetActive(false);
                lives++;
                gracz.transform.position = cel.transform.position;
            

        }
    }
    IEnumerator WaitAndChangeScene()
    {
        yield return new WaitForSeconds(3);


        SceneManager.LoadSceneAsync(0);

    }

}
