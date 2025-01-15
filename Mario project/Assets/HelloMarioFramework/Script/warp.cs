using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public Transform warpPoint; // ワープ先の位置
    public GameObject player;   // プレイヤーオブジェクト

    // 接触時に呼び出される
    private void OnCollisionEnter(Collision collision)
    {
        // プレイヤーが接触した場合
        if (collision.gameObject == player)
        {
            TeleportPlayer();
        }
    }

    // トリガーの場合はこの関数を使う
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            TeleportPlayer();
        }
    }

    // ワープ処理
    private void TeleportPlayer()
    {
        if (warpPoint != null && player != null)
        {
            player.transform.position = warpPoint.position;
        }
    }
}