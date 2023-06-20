using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float time;
    private bool _isRunning;
    private bool _isTimerRanOut;

    private float _minutes, _seconds;
    private float _staticTimeLimit;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        _minutes = Mathf.RoundToInt(time / 60);
        _seconds = Mathf.RoundToInt(time % 60);
    }
    private void FixedUpdate()
    {
        if (time < 0.3f && !_isTimerRanOut)
        {
            time = 0;
            _isTimerRanOut = true;
            SceneManager.LoadScene("Office2");
            StartCoroutine(Result());
            return;
        }

        if (_isRunning && !_isTimerRanOut)
        {
            time -= Time.fixedDeltaTime;
            _minutes = Mathf.FloorToInt(time / 60);
            _seconds = Mathf.FloorToInt(time % 60);
        }
        
        timerText.text = $"{_minutes:00}:{_seconds:00}";
    }
    public void StartTimer()
    {
        _isRunning = true;
    }
    public void PauseTimer()
    {
        _isRunning = false;
    }
    public bool IsTimerRunOut()
    {
        return _isTimerRanOut;
    }

    public void Reset()
    {
        _isTimerRanOut = false;
    }

    IEnumerator Result()
    {
        yield return new WaitForSeconds(0.01f);
        GameObject finalScreen = FindObjectOfType<PointCollectorSystem>(true).gameObject;
        finalScreen.SetActive(true);
    }
}