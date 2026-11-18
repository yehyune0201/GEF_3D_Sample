using Unity.VisualScripting;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{


    public int expPerKill = 35000;
    public int killCount = 3;

    [ContextMenu("레벨 계산")]

    void CalculateLevel()
    {
        int exp = 0;
        int level = 1;


        for (int i = 0; i < killCount; i++)
        {
            for (int Lv = exp += expPerKill; exp >= level * 10000; exp -= level * 10000, level++)

            Debug.Log("레벨업! " + level + "Lv" + "(" + killCount + " 마리째)");
        }

        Debug.Log("최종 Lv" + level + "Lv, 경험치 " + exp + " / " + level * 10000);
    }






  



















}
