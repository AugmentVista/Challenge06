using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text score;
    public int Totalscore;


    void Start()
    {
        Totalscore = 0;
        score.text = "SCORE: " + Totalscore.ToString();
    }

    public void RandomAddScore()
    {
        int randomScore = Random.Range(-999999999, 999999999);
        Totalscore += randomScore;
        score.text = "SCORE: " + Totalscore.ToString();

        if (Totalscore + randomScore <= 0)
        {
            Totalscore = 0;
            score.text = "SCORE: " + Totalscore.ToString();
            return;
        }
    }

    public void ModifyScore(int scoreToModify)
    {
        if (Totalscore + scoreToModify >= 999999999)
        {
            score.text = "MAX SCORE REACHED";
        }
        else
        {
            Totalscore += scoreToModify;
            score.text = "SCORE: " + Totalscore.ToString();
        }

        if (Totalscore + scoreToModify <= 0)
        {
            Totalscore = 0;
            score.text = "SCORE: " + Totalscore.ToString();
            return;
        }

        if (scoreToModify == 0)
        { 
            Totalscore = 0;
            score.text = "SCORE: " + Totalscore.ToString();
            return;
        }
    }
}
