using UnityEngine;

public class Puzzle : MonoBehaviour
{
    [Header("Prefabと生成先")]
    //生成する石のPrefab
    [SerializeField]
    private PuzzleBlock piecePrefab;
    //石を配置する親オブジェクト
    [SerializeField]
    private RectTransform pieceRoot;

    [Header("属性画像")]
    //石のSprite(
    [SerializeField]
    private Sprite[] attributeSprites = new Sprite[5];
    [Header("石の配置設定")]
    [SerializeField]
    private float cellSize = 100f;
    [SerializeField]
    private float spacing = 0f;
    

}
