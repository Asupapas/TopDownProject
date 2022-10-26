using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeEntAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(187f, 2.1f, 0f), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
