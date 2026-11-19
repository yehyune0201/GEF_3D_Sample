using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class BattleLog : MonoBehaviour
{

    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;

    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        int totalDamage = 0;



        List<string> criticals = new List<string>();

        foreach (int damage in damages)
        {
            totalDamage += damage;

            if (damage >= criticalLine)
            {
                criticals.Add("치명타 ");
                Debug.Log(damage);
            }

        }
        Debug.Log("총 데미지 " + totalDamage);

        criticals.Add("치명타 ");
        Debug.Log(criticals[0] + criticals.Count + " 회");
    }


}
