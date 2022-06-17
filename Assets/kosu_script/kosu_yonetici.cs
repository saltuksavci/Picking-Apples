using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class kosu_yonetici : MonoBehaviour
{      
    public GameObject contine_btn;
    public GameObject pause_btn;
    public GameObject game_over;
    public GameObject options_panel;
    public GameObject contine_panel;
    public Transform cocuk;
    public Button adlife;

    private InterstitialAd reklamObjesi;

    void Start()
    {
        
        Time.timeScale = 1.0f;
    }
    private void Update()
    {
        /*
        if (!reklamObjesi.IsLoaded())
        {
            adlife.interactable = true;
           
        }
        else
        {
            adlife.interactable = false;
        }*/
    }
    public void options_btn()
    {

        {
            contine_panel.SetActive(false);
            options_panel.SetActive(true);
        }
    }
    //options penceresi butonları   
    public void options_back_btn()
    {
        contine_panel.SetActive(true);
        options_panel.SetActive(false);
    }
    //oyun ekranındaki play butonu
    public void game_pause_btn()
    {
        contine_panel.SetActive(true);
        pause_btn.SetActive(false);
        Time.timeScale = 0.0f;
    }
    public void contine()
    {
        contine_panel.SetActive(false);
        pause_btn.SetActive(true);
        Time.timeScale = 1.0f;
    }
    //oyunda ölünce gelen ekran butonları
    public void replay_btn()
    {
        game_over.SetActive(false);
        SceneManager.LoadScene("Scenes/elma_toplama_kosu");
    }
    public void menubtn()
    {
        SceneManager.LoadScene("Scenes/main");
        game_over.SetActive(false);
    }
    public void reklam_can_ekle()
    {
        Time.timeScale = 1.0f;
        cocuk.position = new Vector3(0.0f, 0.206f, -5.93f);
        game_over.SetActive(false);
        pause_btn.SetActive(true);
        GameObject.Find("yer").GetComponent<zemin>().can_artiyor = true;
        Time.timeScale = 1.0f;
        cocuk.position = new Vector3(0.0f, 0.206f, -5.93f);

    }
}
