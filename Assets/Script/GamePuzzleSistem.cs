using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePuzzleSistem : MonoBehaviour
{
    public static GamePuzzleSistem instance;
    public List<UIDropSlot> allSlots;
    public int benarSkor=0;
    // Start is called before the first frame update
    void Start()
    {
        instance=this;
        GameObject[] slotgo =  GameObject.FindGameObjectsWithTag("slot");
        foreach(GameObject go in slotgo){
            allSlots.Add(go.GetComponent<UIDropSlot>());
        }
    }

    public void CekUpdateSkor(){
        foreach(UIDropSlot slote in allSlots){
             benarSkor=0;
            slote.CekSlotBenar();
            print("skor="+benarSkor);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
