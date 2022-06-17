using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class main_menu_yonetici : MonoBehaviour

{         
    public GameObject main_manu;
    public GameObject options_panel;
    public TMPro.TextMeshProUGUI bolum1_skor_txt;
    public TMPro.TextMeshProUGUI bolum2_skor_txt;
    public Button bolum2;
    public GameObject key_ımage;
    int oyun_active;
    int bolum1_skor;
    int bolum2_skor;
    void Start()
    {        
        bolum2.interactable = false;
        Time.timeScale = 0.0f;
        InvokeRepeating("elma_ekle", 0.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //bölüm2 skor getirme
        if (!PlayerPrefs.HasKey("hicscore_kosu"))
        {
            PlayerPrefs.SetInt("hicscore_kosu", 0);
        }

        if (PlayerPrefs.HasKey("hicscore_kosu"))
        {
            bolum2_skor = PlayerPrefs.GetInt("hicscore_kosu");
            bolum2_skor_txt.text = bolum2_skor.ToString();
        }
        //bölüm1 skor getirme
        if (!PlayerPrefs.HasKey("hicscore"))
        {
            PlayerPrefs.SetInt("hicscore", 0);          
        }

        if (PlayerPrefs.HasKey("hicscore"))
        {
            bolum1_skor = PlayerPrefs.GetInt("hicscore");
            bolum1_skor_txt.text = bolum1_skor.ToString();
        }
        //bölüm iki aktive
        bolum2_active();
    }

    //main manü ekranı buton kodları

    public void play_episode1()
    {
        SceneManager.LoadScene("Scenes/elma_toplama");
        Time.timeScale = 1.0f;
    }
    public void play_episode2()
    {
        SceneManager.LoadScene("Scenes/elma_toplama_kosu");
        Time.timeScale = 1.0f;
    }
    public void options_btn()
    {
            main_manu.SetActive(false);
            options_panel.SetActive(true);        
    }
    public void Quit()
    {
        Application.Quit();
    }

    //options penceresi butonları   
    public void options_back_btn()
    {        
            main_manu.SetActive(true);
            options_panel.SetActive(false);
    }
    public void bolum2_active()
    {
        if(bolum1_skor>=1000)
        {
            bolum2.interactable = true;
            key_ımage.SetActive(false);
        }
        else
        {
            bolum2.interactable = false;
            key_ımage.SetActive(true);          
        }
    }



   


}
