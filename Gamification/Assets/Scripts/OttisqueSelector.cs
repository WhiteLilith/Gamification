using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OttisqueSelector : MonoBehaviour
{
    [SerializeField] private Image ottisqueImage;
    
    public void CheckForTrueOttisque(Sprite ottisque)
    {
        if(ottisqueImage.sprite != ottisque)
            FindObjectOfType<Player>().ChangeScore(5,-3);
    }
}
