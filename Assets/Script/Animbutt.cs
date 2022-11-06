using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animbutt : MonoBehaviour
{
    public string jenisTransisi="scale";
    // Start is called before the first frame update
    void OnEnable()
    {
        if(jenisTransisi== "scale"){
             transform.localScale= new Vector3(0f,0f,0f);
         LeanTween.scale(gameObject,Vector3.one,.6f).setEaseOutBounce();
        }
        
      //  StartCoroutine(bounceopen());
    }
    IEnumerator bounceopen(){
        transform.localScale= new Vector3(0.75f,0.75f,0.75f);
        LeanTween.scale(gameObject,new Vector3(0.5f,0.5f,0.5f),.2f);
        yield return new WaitForSeconds(0.2f);
        LeanTween.scale(gameObject,Vector3.one,.2f).setEaseInBounce();
    }
}
