using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCube : MonoBehaviour
{
    // 필드
    public Transform refTransform;

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
        Debug.Log("Update");
        refTransform.Translate(0.01f, 0f, 0f);
    }
}
