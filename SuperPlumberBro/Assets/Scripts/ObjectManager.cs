using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectManager : MonoBehaviour
{
    private GameObject[] repairTargets;
    private float lastSpawnTime;
    
    private float waitTime = 5.0f;


    private void OnLevelWasLoaded(int level)
    {
        repairTargets = GameObject.FindGameObjectsWithTag("Repairable");
        foreach (GameObject go in repairTargets)
        {
            go.SetActive(false);
        }
        lastSpawnTime = Time.time;

        waitTime = 5.0f;

    }

    void Update()
    {
        waitTime -= GM.Level;
        if (waitTime < 1.5f)
        {
            waitTime = 1.5f;
        }


        if (Time.time > lastSpawnTime)
        {
            int newTarget = Random.Range(0, repairTargets.Length);
            repairTargets[newTarget].SetActive(true);
            lastSpawnTime += waitTime;
        }
    }
}
