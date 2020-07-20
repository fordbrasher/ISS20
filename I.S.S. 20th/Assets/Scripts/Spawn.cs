using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
  public Transform[] spawnPoints;
  public GameObject targetPrefab;

  bool gameActive;

  public void StartGame()
  {
    gameActive = true;
    StartCoroutine(StartSpawning());
  }

  public void StopGame()
  {
    gameActive = false;
  }

  IEnumerator StartSpawning()
  {
    yield return new WaitForSeconds(1);

    StartCoroutine(SpawnTarget());
  }

  IEnumerator SpawnTarget()
  {
    int index = Random.Range(0,spawnPoints.Length);

    GameObject target = Instantiate(targetPrefab, spawnPoints[index].position, Quaternion.identity);

    yield return new WaitForSeconds(1.25f);

    if (target != null)
      Destroy(target);

    if (gameActive)
    {
      StartCoroutine(SpawnTarget());
    }
    else
    {
      StopCoroutine(SpawnTarget());
    }
  }
}
