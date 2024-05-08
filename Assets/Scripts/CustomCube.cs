using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    // 필드
    [SerializeField] private Transform refTransform;
    [SerializeField] private float moveSpeed = 10f;         // 이동 속도
    [SerializeField] private float rotationSpeed = 360f;    // 회전 속도(단위 초)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        //refTransform = GetComponent<Transform>();
        refTransform = transform;

        refTransform.Translate(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);

        //refTransform.Translate(moveSpeed * horizontal * Time.deltaTime, moveSpeed * vertical * Time.deltaTime, 0f);

        // 이동 Z축 -> 물체 기준 앞뒤 이동.
        //refTransform.localPosition += new Vector3(0f, 0f, vertical * moveSpeed * Time.deltaTime);
        refTransform.position += refTransform.forward * vertical * moveSpeed * Time.deltaTime;

        refTransform.Rotate(new Vector3(0f, horizontal * rotationSpeed * Time.deltaTime, 0f));
    }
}
