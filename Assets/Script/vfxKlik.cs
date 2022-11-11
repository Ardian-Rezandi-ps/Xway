using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class vfxKlik : MonoBehaviour
{[SerializeField]  GraphicRaycaster m_Raycaster;
[SerializeField]RawImage rawImage;
    [SerializeField]GameObject vfx;
    // Start is called before the first frame update
Button idd;
 PointerEventData m_PointerEventData;
    [SerializeField] EventSystem m_EventSystem;
    [SerializeField] RectTransform canvasRect;
 public List<RaycastResult> rex;
 
    void Update()
    {
     transform.position = Input.mousePosition;
        
    }
    // Update is called once per frame

   public void klikUp()
    {
        
        vfx.SetActive(false);
        vfx.SetActive(true);
    }
}
