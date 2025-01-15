using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public Transform warpPoint; // ���[�v��̈ʒu
    public GameObject player;   // �v���C���[�I�u�W�F�N�g

    // �ڐG���ɌĂяo�����
    private void OnCollisionEnter(Collision collision)
    {
        // �v���C���[���ڐG�����ꍇ
        if (collision.gameObject == player)
        {
            TeleportPlayer();
        }
    }

    // �g���K�[�̏ꍇ�͂��̊֐����g��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            TeleportPlayer();
        }
    }

    // ���[�v����
    private void TeleportPlayer()
    {
        if (warpPoint != null && player != null)
        {
            player.transform.position = warpPoint.position;
        }
    }
}