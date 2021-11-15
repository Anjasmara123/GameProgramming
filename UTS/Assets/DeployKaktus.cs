using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployKaktus : MonoBehaviour
{
    public GameObject kaktusPrefabs;
    public float respawnTime = 3f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(kaktusWave()); 
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(kaktusPrefabs) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.y, screenBounds.y));
    }
    // Update is called once per frame
    IEnumerator kaktusWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
