using UnityEngine;

public class Other : MonoBehaviour
{
    public void DeleteObject(string objectName)
    {
        GameObject gameObject = GameObject.Find(objectName);
        if(gameObject) Destroy(gameObject);
    }
}
