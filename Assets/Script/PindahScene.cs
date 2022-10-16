using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void Pindah(string namascene)
    {
        SceneManager.LoadSceneAsync(namascene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
