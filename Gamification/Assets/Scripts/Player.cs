using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int[] score = {6,4,5,12,7,6,6};

    public bool showing;

    public void ChangeScore(int numberOfTask, int scoreToChange)
    {
        score[numberOfTask - 1] += scoreToChange;
    }
    public int[] ReturnScore()
    {
        return score;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
