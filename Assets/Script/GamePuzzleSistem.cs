using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePuzzleSistem : MonoBehaviour
{
    public static GamePuzzleSistem instance;
    public List<UIDropSlot> allSlots;
    public int benarSkor=0;
    public int maxSkor=15;
    public AudioSource SFXbutton;
    public List<SpriteDragItem> potonganAll;
    public GameObject quizUI,winUI;
    public QuizPuzzleManager kuisMgr;
//cek
    // Start is called before the first frame update
    void Start()
    {
        instance=this;
        GameObject[] slotgo =  GameObject.FindGameObjectsWithTag("slot");
        foreach(GameObject go in slotgo){
            allSlots.Add(go.GetComponent<UIDropSlot>());
        }
         foreach(SpriteDragItem sdi in potonganAll){
           sdi.gameObject.SetActive(false);
        }
    }
    public void playbuttonSFX()
    {
        SFXbutton.Play();

    }
    public void OpenQuiz(){
quizUI.SetActive(true);
kuisMgr.LoadSoal();
    }
    public void RevealPuzzlePiece(){
        int r= Random.Range(0,potonganAll.Count);
        potonganAll[r].gameObject.SetActive(true);
        potonganAll.Remove(potonganAll[r]);
    }
    public void CekUpdateSkor(){
        foreach(UIDropSlot slote in allSlots){
             benarSkor=0;
            slote.CekSlotBenar();
            print("skor="+benarSkor);
        }
        if(benarSkor >= maxSkor){
            winUI.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            RevealPuzzlePiece();
        }
    }
}
