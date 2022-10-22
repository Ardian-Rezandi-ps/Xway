using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{

    public GameObject uiPilihanGender;
    public GameObject uiUtama;
    public GameObject uiPenjelasan;

    [System.Serializable]
    public enum StatusUI
    {
        pilihanGender,
        Utama,
        Penjelasan
    }

    public StatusUI currentstatus;
    // Start is called before the first frame update
    void Start()
    {
        currentstatus = StatusUI.pilihanGender;
    }

    public void gantiStatusUI(int indexstatus)
    {
        switch (indexstatus)
        {
            case 0:
                currentstatus = StatusUI.pilihanGender;
                break;
            case 1:
                currentstatus = StatusUI.Utama;
                break;
            case 2:
                currentstatus = StatusUI.Penjelasan;
                break;
        }
        switch (currentstatus)
        {
            case StatusUI.pilihanGender:
                DoPilihanGender();
                break;
            case StatusUI.Utama:
                DoUtama();
                break;
            case StatusUI.Penjelasan:
                DoPenjelasan();
                break;
        }
    }

    void DoPilihanGender()
    {
        uiPilihanGender.SetActive(true);
        uiUtama.SetActive(false);
        uiPenjelasan.SetActive(false);
    }

    void DoUtama()
    {
        uiPilihanGender.SetActive(false);
        uiUtama.SetActive(true);
        uiPenjelasan.SetActive(false);
    }

    void DoPenjelasan()
    {
        uiPilihanGender.SetActive(false);
        uiUtama.SetActive(false);
        uiPenjelasan.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
