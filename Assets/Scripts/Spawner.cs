using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawn = true;
    float height;
    float spawnDelay;
    float minSpawnYpos;
    float maxSpawnYpos; 

    [SerializeField] Column columnPrefab = null;
    [SerializeField] Gap gapPrefab = null;

    GameController gameController;

    IEnumerator Start()
    {
        height = HeightCalculation();

        gameController = FindObjectOfType<GameController>();

        spawnDelay = gameController.GetSpawnDelay();
        minSpawnYpos = gameController.GetMinSpawnYpos();
        maxSpawnYpos = gameController.GetMaxSpawnYpos();

        while (spawn)
        {
            yield return new WaitForSeconds(spawnDelay);
            SpawnColumns(SpawnGap());
        }
    }

    private float HeightCalculation()
    {
        Column column = FindObjectOfType<Column>();
        Gap gap = FindObjectOfType<Gap>();

        float columnHeight = column.GetComponent<SpriteRenderer>().bounds.size.y;
        float gapHeight = gap.GetComponent<SpriteRenderer>().bounds.size.y;

        return columnHeight/2 + gapHeight/2;
    }
    private Vector2 SpawnGap()
    {
        float yPos = Random.Range(minSpawnYpos, maxSpawnYpos);
        Vector2 spawnPos = new Vector2(transform.position.x, yPos);
        Gap newGap = Instantiate(
                     gapPrefab,
                     spawnPos,
                     Quaternion.identity) as Gap;
        return spawnPos;
    }
    private void SpawnColumns(Vector2 gapCoords)
    {
        Vector2 spawnPos1 = new Vector2(gapCoords.x, gapCoords.y + height);
        Vector2 spawnPos2 = new Vector2(gapCoords.x, gapCoords.y - height);
        Column upColumn = Instantiate(
                     columnPrefab,
                     spawnPos1,
                     Quaternion.identity) as Column;
        Column downColumn = Instantiate(
                     columnPrefab,
                     spawnPos2,
                     Quaternion.identity) as Column;
    }

}
