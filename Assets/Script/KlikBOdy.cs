using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KlikBOdy : MonoBehaviour
{
public Text Uitex;
public string kata="kaki tersentuh";
    void OnMouseUp()
    {
        Uitex.text=kata;
    }
    
   
}
