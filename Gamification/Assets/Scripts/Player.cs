using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private static Player instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private int[] defaultScore = {5,5,9,0,0,0,8};
    private int[] score;

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

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu") ResetScore();
    }

    private void ResetScore()
    {
        score = defaultScore;
    }
}
