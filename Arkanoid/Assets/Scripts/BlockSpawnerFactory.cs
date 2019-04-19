using UnityEngine;

public class BlockSpawnerFactory : MonoBehaviour
{
    protected static BlockSpawnerFactory instance;
    public GameObject blockPrefab;
    Vector3 leftSpawnBorder, rightSpawnBorder, topSpawnBorder, bottomSpawnBorder, originPosition;
    Vector3[] spawnArea = new Vector3[4];
    

    int blocksToSpawn;

    void Start()
    {
        instance = this;
        SetBlockSpawnArea();
        blocksToSpawn = Random.Range(10, 15);

        for (int i = 0; i <= blocksToSpawn; i++)
        {
            int blockHealth = Random.Range(1, 4);
            CreateBlock(blockHealth, gameObject, spawnArea);
        }
    }

    public static Block CreateBlock (int blockHealth, GameObject parentObject, Vector3[] spawnArea)
    {
        var block = Instantiate(instance.blockPrefab, new Vector3(Random.Range(spawnArea[0].x, spawnArea[1].x), Random.Range(spawnArea[2].y,spawnArea[3].y), 0f), Quaternion.identity).GetComponent<Block>();
        block.InitializeBlock(blockHealth);
        block.gameObject.transform.parent = parentObject.transform;

        return block;
    }

    void SetBlockSpawnArea()
    {
        leftSpawnBorder = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, 0.7f, 0));
        rightSpawnBorder = Camera.main.ViewportToWorldPoint(new Vector3(0.9f, 0.7f, 0));
        topSpawnBorder = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.9f, 0));
        bottomSpawnBorder = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        originPosition = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.7f, 0));

        spawnArea[0] = leftSpawnBorder;
        spawnArea[1] = rightSpawnBorder;
        spawnArea[2] = topSpawnBorder;
        spawnArea[3] = bottomSpawnBorder;
        transform.position = new Vector2(originPosition.x, originPosition.y);
    }
}
