using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elma_miknatis_kod : MonoBehaviour
{
    kosu_sepet cocuk;
    Transform temas_kupu;
    float mesafe;
    void Start()
    {
        cocuk = GameObject.Find("MaleFreeSimpleMovement1").GetComponent<kosu_sepet>();
        temas_kupu = GameObject.Find("MaleFreeSimpleMovement1/temas_kupu").transform;
    }
    void Update()
    {
        if (cocuk.miknatis_alindi == true)
        {
            mesafe = Vector3.Distance(transform.position, temas_kupu.position);
            if (mesafe <= 20)
            {
                transform.position = Vector3.MoveTowards(transform.position, temas_kupu.transform.position,Time.deltaTime*50);
            }
        }
    }
}
