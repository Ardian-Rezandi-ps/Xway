using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coin : MonoBehaviour
{
public string jenisclaim;    
public int jumlahcoin;
public Text cointext;
public Button buttonclaim;
    void Start(){
     jumlahcoin=   PlayerPrefs.GetInt("coin");
     if(cointext!=null){
        cointext.text=jumlahcoin.ToString();
     }
      if (PlayerPrefs.GetString(jenisclaim)!="tersedia"){
        if(buttonclaim!=null){
             buttonclaim.interactable=false;
        }
       

      }
    }
    public void tambahcoin(int cointambah){
        if (PlayerPrefs.GetString(jenisclaim)=="tersedia"){
        PlayerPrefs.SetString(jenisclaim, "habis");
        jumlahcoin += cointambah;
        PlayerPrefs.SetInt("coin",jumlahcoin);
          if(buttonclaim!=null){
             buttonclaim.interactable=false;
        }
        if(cointext!=null){
        cointext.text=jumlahcoin.ToString();
        }
       
     }
    }
}
