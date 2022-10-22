using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void pindah(string namaSceneNext){
        SceneManager.LoadSceneAsync(namaSceneNext);
    }
}
