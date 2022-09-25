using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Class responsible for dragging itself.
/// Using EventSystems interfaces.
/// </summary>
public class UIDragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //skrip untuk piece puzzle
    // Reference to current item slot.
    public UIDropSlot currentSlot;

    // Reference to the canvas.
    private Canvas canvas;
    public Vector3 penyesuaian= new Vector3(0,-17.3f,0);
    public int indexPuzzle=0;

    // Reference to UI raycaster.
    private GraphicRaycaster graphicRaycaster;

    /// <summary>
    /// IBeginDragHandler
    /// Method called on drag begin.
    /// </summary>
    /// <param name="eventData">Event data.</param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        // Start moving object from the beginning!173.675 191.958
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0) / transform.lossyScale.x; // Thanks to the canvas scaler we need to devide pointer delta by canvas scale to match pointer movement.

        // We need a few references from UI.
        if (!canvas)
        {
            canvas = GetComponentInParent<Canvas>();
            graphicRaycaster = canvas.GetComponent<GraphicRaycaster>();
        }
        
        // Change parent of our item to the canvas.
        transform.SetParent(canvas.transform, true);
        // And set it as last child to be rendered on top of UI.
        transform.SetAsLastSibling();
    }

    /// <summary>
    /// IDragHandler
    /// Method called on drag continuously.
    /// </summary>
    /// <param name="eventData">Event data.</param>
    public void OnDrag(PointerEventData eventData)
    {
        // Continue moving object around screen.
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0) / transform.lossyScale.x; // Thanks to the canvas scaler we need to devide pointer delta by canvas scale to match pointer movement.
    }

    /// <summary>
    /// IEndDragHandler
    /// Method called on drag end.
    /// </summary>
    /// <param name="eventData">Event data.</param>
    public void OnEndDrag(PointerEventData eventData)
    {
        // On end we need to test if we can drop item into new slot. 15.497 -72.43
        var results = new List<RaycastResult>();
        graphicRaycaster.Raycast(eventData, results);

        // Check all hits.
        foreach (var hit in results)
        {
            // If we found slot.
            var slot = hit.gameObject.GetComponent<UIDropSlot>();
            if (slot)
            {
                // We should check if we can place ourselves​ there.
                if (!slot.SlotFilled)
                {
                    
                    currentSlot=slot;
                    print("slot kosong"+currentSlot.name);
                    //mengisi slot kosong
                    if(currentSlot.isSlotTempatPuzzle){
                            
                        if(indexPuzzle==currentSlot.indexBenarslot){
                            print("piece benar indek ke-"+currentSlot.indexBenarslot);
                            //jika index puzzle sama dengan indeks tempat maka piece puzzle benar
                            currentSlot.currentItem = null;
                         currentSlot = slot;
                         currentSlot.currentItem = this;
                        }
                       
                    }
                    // Swapping references.
                    
                }

                // In either cases we should break check loop.
                break;
            }
        }

        // Changing parent back to slot.
        transform.SetParent(currentSlot.transform);
        // And centering item position.
       transform.localPosition = penyesuaian;
      // transform.localPosition = Vector3.zero;
      // transform.Translate(0,-17.3f,0)
    }
}