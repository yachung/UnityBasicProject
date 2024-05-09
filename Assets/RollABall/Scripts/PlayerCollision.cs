using RollABall;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // 점수를 관리하는 게임 관리자
    [SerializeField] private GameManager gameManager;

    // 충돌에 비교할 태그 문자열 값
    private string itemTag = "Item";

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"OnTriggerEnter 충돌한 대상 : {other.name}");

        // 부딪힌 물체가 아이템인지 확인
        if (other.CompareTag(itemTag)) Destroy(other.gameObject);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log($"OnTriggerStay 충돌한 대상 : {other.name}");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log($"OnTriggerExit 충돌한 대상 : {other.name}");
    //}
}
