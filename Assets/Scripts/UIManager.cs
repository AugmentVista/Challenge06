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

    public void ModifyScore(int scoreToModify)
    {
        if (Totalscore >= 999999999)
        {
            Totalscore += scoreToModify;
            score.text = "MAX SCORE REACHED";

        }
        else
        {
            Totalscore += scoreToModify;
            score.text = "SCORE: " + Totalscore.ToString();
        }

        if (Totalscore <= 0)
        {
            Totalscore += scoreToModify;
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
