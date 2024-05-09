using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"OnTriggerEnter �浹�� ��� : {other.name}");

        // �ε��� ��ü�� ���������� Ȯ��
        if (other.CompareTag("Item")) Destroy(other.gameObject);
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log($"OnTriggerStay �浹�� ��� : {other.name}");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log($"OnTriggerExit �浹�� ��� : {other.name}");
    //}
}
