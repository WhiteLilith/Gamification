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

    private void Start()
    {
        CountRightAnswers();
    }

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
            Debug.Log($"{answer.rightAnswer}: дано{answer.countedAnswers}/надо{answer.countOfAnswers}");
        }
    }
}