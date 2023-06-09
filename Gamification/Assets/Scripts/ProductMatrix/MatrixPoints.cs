using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MatrixPoints : MonoBehaviour
{
    [SerializeField] private List<Transform> cells;
    [SerializeField] private List<Transform> wrongItems;
    
    private int _totalTrueAnswers = 0;

    public void GivePoints()
    {
        foreach (var cell in cells)
        {
            if (cell.childCount > 0 && !wrongItems.Contains(cell.GetChild(0)))
                _totalTrueAnswers++;
        }
        Debug.Log(_totalTrueAnswers);
        
        if(_totalTrueAnswers == 8)
            Debug.Log("XDDD");
    }
}
