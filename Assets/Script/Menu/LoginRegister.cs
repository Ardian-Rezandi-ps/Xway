using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginRegister : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField emailif, passwordif,usernameif,userifLogin, passwordifLogin;
    public Text errortx;
    public string namaSceneNext;
   
   public void DaftarPeserta(){
       //untuk mengisi data di dalam game(save game data)
        //untuk mengisi data email dan password

       PlayerPrefs.SetString(usernameif.text,passwordif.text);
       //untuk mengisi alamat dari akun email(adress)
        PlayerPrefs.SetString("address"+usernameif.text, emailif.text);
        SceneManager.LoadSceneAsync(namaSceneNext);
    }
   public void LoginPeserta(){
       //haskey=untuk mengecek apakah email sudah terdaftar?
        if(PlayerPrefs.HasKey(userifLogin.text)){
            //kondisi email terdaftar melihat passsword dari email input login
            string pass= PlayerPrefs.GetString(userifLogin.text);
            //apakah password  saved di game sama dengan input password?
            if(pass== passwordifLogin.text){
                PlayerPrefs.SetString("daily login","tersedia");
                SceneManager.LoadSceneAsync(namaSceneNext);
            }else{
                //password salah
                errortx.text="Password salah";
            }
        }else{
            errortx.text="Email tidak terdaftar";
            //kondisi email tidak terdaftar
        }
     
   }
}
