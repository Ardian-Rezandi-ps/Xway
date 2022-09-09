using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public string soal;
    public string[] jawaban;
    public int indexJawabanBenar;

    public Text textSoal;
    public Text[] textJawaban;

    public Text textScore;
    public static int score = 0;
    public static int nomorSoal = 1;    
    public static int maxSoal = 3;

    public GameObject panelWin;

    void Start()
    {
        textSoal.text = soal;
        textScore.text = "Score : " + score.ToString();

        //versi 1
        //textJawaban[0].text = jawaban[0];
        //textJawaban[1].text = jawaban[1];
        //textJawaban[2].text = jawaban[2];
        //textJawaban[3].text = jawaban[3];

        //versi 2
        for(int i=0; i<=3; i++){
            textJawaban[i].text = jawaban[i];
        }
    }

    public void ValidasiJawaban(int indexJawabanPlayer)
    {
        if(indexJawabanPlayer == indexJawabanBenar){
            score += 10;
        }
        else {
            score -= 5;
        }

        if(nomorSoal == maxSoal) {
            panelWin.SetActive(true);
        }
        else{
            nomorSoal +=1;
            SceneManager.LoadScene("Quiz" + nomorSoal);
        }
    }
}
