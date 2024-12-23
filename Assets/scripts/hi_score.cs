using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score
{
    public string Key;
    public int Value;
}
public class hi_score : MonoBehaviour
{
    public Button hi;
    public TMP_Text Hi_Score;
    public string nick = "Patryk";
    public movement move;

    List<KeyValuePair<string, int>> wyniki = new List<KeyValuePair<string, int>>();


    void Start()
    {
        //PlayerPrefs.DeleteAll();
        LoadGame();
    }


    void Update()
    {

    }
    bool liczbaDodana = false;
    public void setHi_Score()
    {
        wyniki.Add(new KeyValuePair<string, int>(nick, move.ruchy));
        wyniki.Sort((x, y) => x.Value.CompareTo(y.Value));

        foreach (var wynik in wyniki)
        {
            Debug.Log($"Gracz: {wynik.Key}, Wynik: {wynik.Value}");
        }
        SaveGame();
        SceneManager.LoadSceneAsync(0);


    }
    public void wiewHi_Score()
    {
       
        if (wyniki.Count > 0)
        {


           
            for (int i = 0; i < wyniki.Count; i++)
            {
                Hi_Score.text += $"{i + 1}. {wyniki[i].Key} - {wyniki[i].Value}\n";  
            }
            
        }
        else
        {
            Hi_Score.text = "No scores available.";  
            hi.enabled = false;
        }
        hi.enabled = false;
    }


    public void SaveGame()
    {
        for (int i = 0; i < wyniki.Count; i++)
        {
            PlayerPrefs.SetString("nicki" + i, wyniki[i].Key);
            PlayerPrefs.SetInt("score" + i, wyniki[i].Value);
        }
        PlayerPrefs.Save();
    }
    public void LoadGame()
    {

        int i = 0;
        while (i < 5 && PlayerPrefs.HasKey("nicki" + i))
        {
            string nickname = PlayerPrefs.GetString("nicki" + i);
            int score = PlayerPrefs.GetInt("score" + i);

            wyniki.Add(new KeyValuePair<string, int>(nickname, score));

            i++;
        }
    }
    public void setno()
    {
        SceneManager.LoadSceneAsync(0);
    }


}
