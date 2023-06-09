using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int[] score = {5,4,5,12,7,6,6};

    public bool showing, map, gallery;

    public void ChangeScore(int numberOfTask, int scoreToChange)
    {
        score[numberOfTask - 1] += scoreToChange;
    }
    public int[] ReturnScore()
    {
        return score;
    }

    public void SetMap()
    {
        map = true;
    }
    
    public void SetGallery()
    {
        gallery = true;
    }

    public void CheckBool()
    {
        if (gallery) score[0] += 1;
        if (map) score[0] += 1;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
