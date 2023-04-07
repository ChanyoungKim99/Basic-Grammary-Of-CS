using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        // 1��
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)���� (5,6)������ �Ÿ� : " + distance);

        // 2��
        int love = 80;

        if(love > 90)
        {
            Debug.Log("Ʈ�翣�� : �����ΰ� ��ȥ�ߴ�!");
        }
        else if (love > 70)
        {
            Debug.Log("�¿��� : �����ΰ� ��Ͱ� �Ǿ���!");
        }
        else
        {
            Debug.Log("��忣�� : �����ο��� ������.");
        }

        // 3��
        int[] students = new int[5];
        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for(int i = 0; i < students.Length; i++)        // Length�� �迭 Ÿ�� ���ο� �����ϴ� ������Ƽ
        {
            Debug.Log((i + 1) + "�� �л��� ���� : " + students[i]);
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
