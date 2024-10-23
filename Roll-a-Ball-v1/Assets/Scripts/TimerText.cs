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

    private int itemsTouched = 0;  // �J�E���g�p�̕ϐ�
    private bool isTimerRunning = true;  // �^�C�}�[�̃I���E�I�t

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // �^�C�}�[����~���Ă��Ȃ��ꍇ�̂ݎ��Ԃ����Z
        if (isTimerRunning)
        {
            second += Time.deltaTime;

            //60����1���Ԃɒu������
            if (minute >= 60)
            {
                hour++;
                minute = 0;
            }
            //60�b��1���ɒu������
            if (second > 60f)
            {
                minute++;
                second -= 60f;
            }

            //���Ԃ�\��
            timerText.text = hour.ToString() + ":" + minute.ToString("00") + ":" + second.ToString("f2");
        }
    }

    // �A�C�e���ɐG�ꂽ�ۂɌĂяo����郁�\�b�h
    public void ItemTouched()
    {
        itemsTouched++;

        // 6���ׂẴA�C�e���ɐG�ꂽ�ꍇ�A�^�C�}�[���~
        if (itemsTouched >= 6)
        {
            isTimerRunning = false;
        }
    }
}

