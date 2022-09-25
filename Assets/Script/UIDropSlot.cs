using UnityEngine;

/// <summary>
/// Item slot class.
/// Store reference to the object inside slot.
/// </summary>
public class UIDropSlot : MonoBehaviour
{
    //skrip untuk tempat piece
    // Reference to the item inside slot.
    public UIDragItem currentItem;

    public bool isSlotTempatPuzzle=true;
    public int indexBenarslot=0;

    // Tells if slot is filled by other item.
    public bool SlotFilled => currentItem;
}