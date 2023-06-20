using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float time;
    private static bool _isRunning;
    private static bool _isTimerRanOut;

    private static float _minutes, _seconds;
    private static float _staticTimeLimit;
    
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
    public static void StartTimer(bool isStart)
    {
        _isRunning = isStart;
    }
    public static void PauseTimer(bool isPause)
    {
        _isRunning = isPause;
    }
    public static bool IsTimerRunOut()
    {
        return _isTimerRanOut;
    }

    IEnumerator Result()
    {
        yield return new WaitForSeconds(0.01f);
        GameObject finalScreen = FindObjectOfType<PointCollectorSystem>(true).gameObject;
        finalScreen.SetActive(true);
    }
}