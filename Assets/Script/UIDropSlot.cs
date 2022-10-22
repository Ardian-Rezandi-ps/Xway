using UnityEngine;

/// <summary>
/// Item slot class.
/// Store reference to the object inside slot.
/// </summary>
public class UIDropSlot : MonoBehaviour
{
    //cek
    //skrip untuk tempat piece
    // Reference to the item inside slot.
    public SpriteDragItem currentItem;

    public bool isSlotTempatPuzzle=true;
    public int indexBenarslot=0;
    
    
    public void CekSlotBenar(){
        if(currentItem!=null){
            if(indexBenarslot==currentItem.indexPuzzle){
                GamePuzzleSistem.instance.benarSkor+=1;
        }
        }
       
    }
   

   // void Start()
   // {
      //  if(!isSlotTempatPuzzle){
       //    SlotFilled=true;
      //  }
  //  }
}