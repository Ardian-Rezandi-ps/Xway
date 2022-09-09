using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PilihKarakter : MonoBehaviour
{
   public Image fotoTerpilih,bgFotoTerpilih;
   public Sprite[] spritePerKarakter;
   public Text namaKarakterTerpilih;
   public string[] namaKarakter;
   public Color[] warnaBG;
   public InputField deskripsiIField;
   public int indekTerpilih=0;
   void Start()
   {
       GantiKarakter(0);
   }
   public void GantiKarakter(int indeks){
       indekTerpilih=indeks;
       LoadDeskripsi();
       fotoTerpilih.sprite= spritePerKarakter[indeks];
       namaKarakterTerpilih.text= namaKarakter[indeks];
       bgFotoTerpilih.color= warnaBG[indeks];
   }  
   public void SimpanDeskripsi(){
       PlayerPrefs.SetString("deskripsi"+indekTerpilih,deskripsiIField.text);
   }     
   public void LoadDeskripsi(){
        deskripsiIField.text= PlayerPrefs.GetString("deskripsi"+indekTerpilih);
   }
    
}
