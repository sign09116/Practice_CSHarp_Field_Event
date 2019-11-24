using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    #region 屬性
    /// <summary>
    /// 小雞移動速度
    /// </summary>
    [Header("移動速度"), Range(1, 100)]
    public float Speed;
    /// <summary>
    /// 小雞跳躍高度
    /// </summary>
    [Header("跳躍高度"), Range(1, 50)]
    public float JumpForce;
    [Header("對話內容"), Tooltip("小雞要說的內容")]
    /// <summary>
    /// 小雞的對話
    /// </summary>
    public string Talk;
    /// <summary>
    /// 小機撿取雞蛋
    /// </summary>
    [Header("是否撿到雞蛋")]
    public bool GetEgg;
    #endregion

    #region 事件
    private void Awake()
    {
        print("遊戲開始!!");
        print(Talk);
    }

    #endregion

    #region 方法
    #endregion

}
