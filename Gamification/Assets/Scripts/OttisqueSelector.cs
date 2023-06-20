using UnityEngine;
using UnityEngine.UI;

public class OttisqueSelector : MonoBehaviour
{
    [SerializeField] private Image ottisqueImage;
    
    public void CheckForTrueOttisque(Sprite ottisque)
    {
        FindObjectOfType<Player>().ChangeScore(5, ottisqueImage.sprite == ottisque ? 7 : 4);
    }
}
