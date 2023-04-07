using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // 1번
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);

        // 2번
        int love = 80;

        if(love > 90)
        {
            Debug.Log("트루엔딩 : 히로인과 결혼했다!");
        }
        else if (love > 70)
        {
            Debug.Log("굿엔딩 : 히로인과 사귀게 되었다!");
        }
        else
        {
            Debug.Log("배드엔딩 : 히로인에게 차였다.");
        }

        // 3번
        int[] students = new int[5];
        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for(int i = 0; i < students.Length; i++)        // Length는 배열 타입 내부에 존재하는 프로퍼티
        {
            Debug.Log((i + 1) + "번 학생의 점수 : " + students[i]);
        }   
    }

    float GetDistance (float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        float distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);

        return distance;
    }
}
