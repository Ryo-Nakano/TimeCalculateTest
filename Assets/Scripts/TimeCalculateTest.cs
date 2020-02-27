using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;//DateTime構造体使う為に必要！

public class TimeCalculateTest : MonoBehaviour {

    DateTime today;//現在の"日付のみ"を格納しておくための変数
    DateTime now;//現在の日時(日付や時刻を含む)を格納しておく為の変数

    DateTime startTime;
    DateTime nowTime;

    int leftTime;//経過時間
    int leftDay;//経過日数
    int leftMinutes;//経過分数
    int leftSeconds;//経過秒数
    int leftSecondsSum;//合計経過秒数(経過日数 × 24 × 60 × 60 + 経過時間 × 60 × 60 + 経過分数 × 60 + 経過秒数)

	void Start () {
                startTime = DateTime.Now;//現在時刻を取得→変数starTimeに
                Debug.Log("startTime : " + startTime);//コンソールに出力
	}
	
	void Update () {
                if(Input.GetKeyDown("space"))
                {
                        nowTime = DateTime.Now; //現在時刻取得

                        //startTimeからdayまでの経過"日数"を計算
                        leftDay = nowTime.Subtract(startTime).Days;//経過日数を計算→変数leftDayに格納
                        Debug.Log("経過日数：" + leftDay + "日");//コンソールに出力

                        //startTimeからdayまでの経過"時間"を計算
                        leftTime = nowTime.Subtract(startTime).Hours;//経過時間を計算→変数leftTimeに格納
                        Debug.Log("経過時間：" + leftTime + "時間");//コンソールに出力

                        leftMinutes = nowTime.Subtract(startTime).Minutes;//経過時間を計算→変数leftMinutesに格納
                        Debug.Log("経過分数：" + leftMinutes + "分");//コンソールに出力

                        leftSeconds = nowTime.Subtract(startTime).Seconds;//経過時間を計算→変数leftSecondsに格納
                        Debug.Log("経過秒数：" + leftSeconds + "秒");//コンソール出力

                        leftSecondsSum = leftDay * 24 * 60 * 60 + leftTime * 60 * 60 + leftMinutes * 60 + leftSeconds;//全て秒に換算
                        Debug.Log("合計経過秒数：" + leftSecondsSum + "秒");//コンソールに出力

                        Debug.Log("~~~ ~~~ ~~~ ~~~ ~~~");



                        //【Timespan構造体を使う方法もある】
                        // ↑多分こっちのTimeSpan使う実装の方が良さそう

                        TimeSpan diff = nowTime - startTime; //差分計算
                        Debug.Log("diff：" + diff);//差分を表示(そのまま)
                        Debug.Log("経過日数：" + diff.TotalDays + "日");//経過日数を表示(少数)
                        Debug.Log("経過時間：" + diff.TotalHours + "時間");//経過時間を表示(少数)
                        Debug.Log("経過分数：" + diff.TotalMinutes + "分");//経過分数を表示(少数)
                        Debug.Log("経過秒数：" + diff.TotalSeconds + "秒");//経過秒数を表示(少数)

                        Debug.Log("==========================");

                }
	}
}
