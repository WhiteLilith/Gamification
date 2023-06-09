using TMPro;
using UnityEngine;

public class PointCollectorSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI summaryPointAmount;

    [SerializeField] private TextMeshProUGUI pointText1;
    [SerializeField] private TextMeshProUGUI pointText2;
    [SerializeField] private TextMeshProUGUI pointText3;
    [SerializeField] private TextMeshProUGUI pointText4;
    [SerializeField] private TextMeshProUGUI pointText5;
    [SerializeField] private TextMeshProUGUI pointText6;
    [SerializeField] private TextMeshProUGUI pointText7;

    private int pointSum, point1, point2, point3, point4, point5, point6, point7;

    private void OnEnable()
    {
        GetSomePoints();
    }

    private void GetSomePoints()
    {
        Player playerData = FindObjectOfType<Player>();
        var score = playerData.ReturnScore();
        point1 = score[0];
        point2 = score[1];
        point3 = score[2];
        point4 = score[3];
        point5 = score[4];
        point6 = score[5];
        point7 = score[6];
        pointSum = point1 + point2 + point3 + point4 + point5 + point6 + point7;

        summaryPointAmount.text = pointSum.ToString();
        pointText1.text = point1.ToString();
        pointText2.text = point2.ToString();
        pointText3.text = point3.ToString();
        pointText4.text = point4.ToString();
        pointText5.text = point5.ToString();
        pointText6.text = point6.ToString();
        pointText7.text = point7.ToString();
    }
}
