using UnityEngine;
using UnityEngine.UI;

//ブロックの属性
public enum PuzzleAttribute
{
    Fire,   //火
    Watar,  //水
    Wood,   //木
    Light,  //光
    Dark    //闇
}
public class PuzzleBlock : MonoBehaviour
{
    //Blockの種類
    public PuzzleAttribute Type {  get; private set; }

    //
    [SerializeField]
    private Image blockimage;

    //盤面上の座標
    public int X { get; private set; }
    public int Y { get; private set; }
    /// <summary>
    /// ブロックの初期化関数
    /// </summary>
    /// <param name="type"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="sprite"></param>
    public void Initializer(
        PuzzleAttribute type,
        int x,
        int y,
        Sprite sprite)
    {
        Type = type;
        X = x;
        Y = y;
        blockimage.sprite = sprite;
    }
    /// <summary>
    /// 座標を変更する
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public void SetPosition(int x, int y)
    {
        X = x; 
        Y = y;
    }
}
