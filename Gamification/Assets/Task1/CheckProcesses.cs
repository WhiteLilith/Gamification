using System;
using UnityEngine;

public class CheckProcesses : MonoBehaviour
{
    [Serializable]
    private struct answerToCheck
    {
        public string rightAnswer;
        public int countOfAnswers;
        public int countedAnswers;
    }
    [SerializeField] private CheckDropDown[] dropDowns;
    [SerializeField] private answerToCheck[] rightAnswers;

    public void CountRightAnswers()
    {
        foreach (var dropDown in dropDowns)
        {
            for (var answer = 0; answer < rightAnswers.Length; answer++)
            {
                if (dropDown.CheckAnswer(rightAnswers[answer].rightAnswer))
                {
                    rightAnswers[answer].countedAnswers++;
                    break;
                }
            }
        }

        foreach (var answer in rightAnswers)
        {
            if (answer.countedAnswers != answer.countOfAnswers)
            {
                FindObjectOfType<Player>().ChangeScore(6,-3);
                return;
            }
        }
    }
}