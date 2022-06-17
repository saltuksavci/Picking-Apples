using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ses : MonoBehaviour
{
    public AudioListener sound;
    int gelenses;
    public GameObject sound_of_btn;
    public GameObject sound_on_btn;
    void Start()
    {
        gelenses = PlayerPrefs.GetInt("sound", 1);
        if (gelenses == 1)
        {
            sound.enabled=true;
            sound_on_btn.SetActive(true);
            sound_of_btn.SetActive(false);
        }
        if (gelenses == 0)
        {
            sound.enabled=false;
            sound_on_btn.SetActive(false);
            sound_of_btn.SetActive(true);
        }

    }
    void Update()
    {

    }
    public void soundon()
    {
        PlayerPrefs.SetInt("sound", 0);
        
        sound.enabled = false;
        sound_of_btn.SetActive(true);
        sound_on_btn.SetActive(false);
    }
    public void soundof()
    {
        PlayerPrefs.SetInt("sound", 1);
        sound.enabled = true;
        sound_of_btn.SetActive(false);
        sound_on_btn.SetActive(true);
    }
}
