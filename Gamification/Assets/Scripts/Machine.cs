using System;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public new string name;
    public string[] technologicalProcesses;

    private void Start()
    {
        name = this.gameObject.name;
    }
}
