using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//DateTime構造体使う為に必要！

public class TimeCalculateTest : MonoBehaviour {

    DateTime today;//現在の"日付のみ"を格納しておくための変数
    DateTime now;//現在の日時(日付や時刻を含む)を格納しておく為の変数

    DateTime lastDate = new DateTime(2018, 04, 25, 06, 00, 00);
    DateTime newTime = new DateTime(2018, 04, 26, 22, 00, 00);//日付をこっちから指定する時はこうやって宣言(DateTime型)

    int leftTime;//経過時間
    int leftDay;//経過日数
    int leftMinutes;//経過分数
    int leftMinutesSum;//合計経過時間(経過日数 × 24 × 60 + 経過時間 × 60 + 経過分数)

	// Use this for initialization
	void Start () {
        
        Debug.Log(newTime);//newTimeをコンソール出力
        Debug.Log(lastDate);//lastTimeをコンソール出力


        //lastDateからdayまでの経過"日数"を計算
        leftDay = newTime.Subtract(lastDate).Days;//経過日数を計算→変数leftDayに格納
        Debug.Log("経過日数：" + leftDay + "日");//コンソールに出力

        //lastDateからdayまでの経過"時間"を計算
        leftTime = newTime.Subtract(lastDate).Hours;//経過時間を計算→変数leftTimeに格納
        Debug.Log("経過時間：" + leftTime + "時間");//コンソールに出力

        leftMinutes = newTime.Subtract(lastDate).Minutes;
        Debug.Log("経過分数：" + leftMinutes + "分");

        leftMinutesSum = leftDay * 24 * 60 + leftTime * 60 + leftMinutes;//経過日数を時間に換算→leftTimeと合計
        Debug.Log("合計経過分数：" + leftMinutesSum + "分");//コンソールに出力
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("space"))
        {
            
        }
	}
}
