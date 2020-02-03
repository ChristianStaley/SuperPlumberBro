using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeModel : MonoBehaviour
{
    public GameObject wrench;
    public GameObject hammer;

    private void Start()
    {
        wrench.SetActive(false);
        hammer.SetActive(false);
    }

    void Update()
    {
        if(GM.tool == "Hammer")
        {
            hammer.SetActive(true);
            wrench.SetActive(false);
        }
        if (GM.tool == "Wrench")
        {
            wrench.SetActive(true);
            hammer.SetActive(false);
        }
    }
}
