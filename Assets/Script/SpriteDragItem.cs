using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDragItem : MonoBehaviour
{ 
    public UIDropSlot currentSlot,tempSlot;
     //public Vector3 penyesuaian= new Vector3(0,0f,0);
  public int indexPuzzle=0;
    // Start is called before the first frame update
     public bool isDragging=false;
    public void OnMouseDown()  {
        
        isDragging = true;
        isOutrange=true;
        GamePuzzleSistem.instance.playbuttonSFX();
    }
    public void OnMouseUp()  {
        if(tempSlot!=null){
            GamePuzzleSistem.instance.playbuttonSFX();
            // if(!tempSlot.SlotFilled){
            if (!isOutrange){
               tempSlot.currentItem=this;
                 
                   // transform.SetParent(tempSlot.gameObject.transform);
                transform.position= tempSlot.transform.position;
               // transform.localPosition += penyesuaian;
                transform.SetAsLastSibling();
                currentSlot=tempSlot;
                GamePuzzleSistem.instance.CekUpdateSkor();
             //   }
               }
           // }
           

        }
        isDragging = false;
    }
     bool isOutrange=true;
    public void OnMouseDrag()   {
       
       isOutrange=true;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);  
        transform.SetAsLastSibling();
       
for(int i=0;i< GamePuzzleSistem.instance.allSlots.Count;i++){
    if(Vector2.Distance(transform.position
    ,GamePuzzleSistem.instance.allSlots[i].gameObject.transform.position)< .6f){
        tempSlot=GamePuzzleSistem.instance.allSlots[i];
        isOutrange=false;
    }
}
if(isOutrange){
  
    tempSlot=null;
}
        //if(Vector2.Distance(transform.position,))
    }
 
}
