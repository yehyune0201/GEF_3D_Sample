using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{

    // 실습 123을 이 스크립트에 넣어 놓았습니다.


    public int[] golds = { 300, 1200, 50, 800 };


    [ContextMenu("배열 실습")]
    
    void ShowGolds()
    {

        int total = 0;

        for (int i = 0; i < golds.Length; i++)
        {
            Debug.Log(i + "번 : " + golds[i]);
            total += golds[i];       
        }
        Debug.Log("합계 " + total);
    }

    //ListPractice*****************************

    [ContextMenu("List 실습")]
    void ShowInventory()
    {
        List<string> inventory = new List<string>();

        inventory.Add("포션");
        inventory.Add("화살");
        inventory.Add("포션");
        inventory.Add("열쇠");
        inventory.Remove("포션");

        Debug.Log("아이템 " + inventory.Count + " 개");
        Debug.Log("열쇠 있음: " + inventory.Contains("열쇠"));

        for (int i = 0; i < inventory.Count; i++)

        {
            Debug.Log(i + "번: " + inventory[i]);
        }
    }

    //ForeachPractice +++++++++++++++++++++++++
    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()
    {
        int aliveCount = 0;
        int hpSum = 0;
        foreach (int hp in monsterHps)
        {

            if (hp > 0)
            {
                aliveCount++;
                hpSum += hp;
            }
        }
        Debug.Log("살아 있는 몬스터 " + aliveCount + " 마리");
        Debug.Log("남은 체력 합 " + hpSum);
    }

}
