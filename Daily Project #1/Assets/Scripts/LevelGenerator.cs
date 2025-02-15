using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Vector2Int size;
    public Vector2 offSet;
    public GameObject brickPrefab;


    private void Awake()
    {
        for (int i = 0;i < size.x; i++)
        {
            for(int j = 0;j < size.y; j++)
            {
                GameObject newBrick = Instantiate(brickPrefab, transform);
                newBrick.transform.position = transform.position + new Vector3((float)((size.x- 1)*.5f - i) * offSet.x, j * offSet.y, 0);
            }
        }
    }
}
