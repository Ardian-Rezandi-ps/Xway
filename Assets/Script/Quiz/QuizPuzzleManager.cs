using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class QuizPuzzleManager : MonoBehaviour
{
    public int indexJawabanBenar;
    public TextMeshProUGUI textSoal;
    public List<TextMeshProUGUI> textJawaban;
    public TextMeshProUGUI salahbenartext;
    public int indekBenar;
    public Image timerImg;
    public GameObject panelWin, panelQuiz;
    public float timerTime = 0, timerMax = 0, decreasetime = 0.1f, timeUsed = 0, timecumulative = 0;
   // public List<GameObject> PuzzleUnlock;
    public List<SoalJawab> SoalSoal;

    private void Update()
    {
        if (Time.time >= timerTime + 1)
        {
            timeUsed++;
            timecumulative++;
            timerImg.fillAmount -= decreasetime;
            timerTime = Time.time;
            if (timerImg.fillAmount <= 0)
            {

            }
        }


    }
    void Start()
    {

        decreasetime = 1 / timerMax;

    }
    public void LoadSoal()
    {
        panelWin.SetActive(false);
        panelQuiz.SetActive(true);
        int rnd = Random.Range(0, SoalSoal.Count);
        textSoal.text = SoalSoal[rnd].soal;
        for (int i = 0; i < textJawaban.Count; i++)
        {
            textJawaban[i].text = SoalSoal[rnd].jawaban[i];

        }
        indexJawabanBenar = SoalSoal[rnd].indekBenar;

    }
    public void ValidasiJawaban(int indexJawabanPlayer)
    {
        if (indexJawabanPlayer == indexJawabanBenar)
        {

            salahbenartext.text = "Jawaban Benar. Anda mendapat 1 Puzzle!";
           GamePuzzleSistem.instance.RevealPuzzlePiece();

        }
        else
        {

            salahbenartext.text = "Yah, Jawaban Salah. Coba lagi...";
        }

        panelWin.SetActive(true);
    }
}