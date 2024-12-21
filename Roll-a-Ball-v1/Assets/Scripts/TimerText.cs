using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    private TextMeshProUGUI timerText;

    private float second;
    private int minute;
    private int hour;

    private int itemsTouched = 0;  // カウント用の変数
    private bool isTimerRunning = true;  // タイマーのオン・オフ

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // タイマーが停止していない場合のみ時間を加算
        if (isTimerRunning)
        {
            second += Time.deltaTime;

            //60分→1時間に置き換え
            if (minute >= 60)
            {
                hour++;
                minute = 0;
            }
            //60秒→1分に置き換え
            if (second > 60f)
            {
                minute++;
                second -= 60f;
            }

            //時間を表示
            timerText.text = hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("f2");
        }
    }

    // アイテムに触れた際に呼び出されるメソッド
    public void ItemTouched()
    {
        itemsTouched++;

        // 6個すべてのアイテムに触れた場合、タイマーを停止
        if (itemsTouched >= 6)
        {
            isTimerRunning = false;
        }
    }
}

