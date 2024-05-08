using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    // 필드
    [SerializeField] private Transform refTransform;
    [SerializeField] private float moveSpeed = 10f;

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
        // Console 창에 문자를 출력해주는 메소드
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);

        refTransform.Translate(moveSpeed * horizontal * Time.deltaTime, moveSpeed * vertical * Time.deltaTime, 0f);
    }
}
