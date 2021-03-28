using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quests : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject ItemQuest;
    public bool ativaQuest;
    void Start()
    {
        ativaQuest = false;
    }
    void Update()
    {
        if(ativaQuest){
            PopUp.SetActive(true);
            ItemQuest.SetActive(false);
        }else{
            PopUp.SetActive(false);
            ItemQuest.SetActive(true);
        }
        
    }
    public void AtivaPopUp(){
        ativaQuest = true;
    }
    public void DesativaPopUp(){
        ativaQuest = false;
    }
}
