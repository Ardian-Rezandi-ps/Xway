using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Exp : MonoBehaviour
{
public string jenisclaim;    
public int jumlahexp;
public Text exptext;
public Button buttonclaim;
    void Start(){
     jumlahexp=   PlayerPrefs.GetInt("exp");
     if(exptext!=null){
        exptext.text=jumlahexp.ToString();
     }
      if (PlayerPrefs.GetString(jenisclaim)!="tersedia"){
        if(buttonclaim!=null){
             buttonclaim.interactable=false;
        }
       

      }
    }
    public void tambahexp(int exptambah){
        if (PlayerPrefs.GetString(jenisclaim)=="tersedia"){
        PlayerPrefs.SetString(jenisclaim, "habis");
        jumlahexp += exptambah;
        PlayerPrefs.SetInt("exp",jumlahexp);
          if(buttonclaim!=null){
             buttonclaim.interactable=false;
        }
        if(exptext!=null){
       exptext.text=jumlahexp.ToString();
        }
       
     }
    }
}

