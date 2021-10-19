using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_int : MonoBehaviour
{
    public Image ImageUp;
    public Image ButtonVolume;

    public Image ImageDown;
    public Image ButtonSetting;
    public Image ButtonScreen;
    public Image ButtonHistory;

    public Image Setting;
    public Image SettingBackBt;
    public Image SettingBlock1;
    public Image SettingBlock2;
    public Image SettingBlock3;
    public Image SettingBlock4;
    public Image SettingBlock5;
    public Image SettingBlock6;
    public Image SettingBlock7;
    

    public GameObject SettingActive;
    public GameObject SettingText;

    static int With;
    static int Height;

    // Start is called before the first frame update
    void Start()
    {
        With = Screen.width;
        Height = Screen.height;

        float SizeH = Height * 0.1f - 10;

        change(SizeH);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (With != Screen.width)
        {
            With = Screen.width;
            Height = Screen.height;
            change(Height * 0.1f - 10);

        }
    }

    void change(float SizeH)
    {
        float Bloack = SizeH + 30;

        float Size = (Height - Bloack - 100 - (10*7)) / 7f;

        //������� ������� ������� � ������� � ��������� � �� ������
        ImageUp.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 1, SizeH);
        ImageUp.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 1, With);

        //������ ����������� ������ ���������
        ButtonVolume.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 1, SizeH);
        ButtonVolume.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 1, SizeH);

        //������� ������ ������� � ������� � ��������� � �� ������
        ImageDown.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 0, SizeH + 15);
        ImageDown.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 1, With);

        //������ ����������� ������ ��������
        ButtonSetting.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 10, SizeH);
        ButtonSetting.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 2, SizeH);

        //������� ������� ������� � ������� � ��������� � �� ������
        ButtonScreen.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, (With / 2) - (SizeH / 2), SizeH);
        ButtonScreen.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 2, SizeH);

        //������ ����������� ������ �������
        ButtonHistory.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Right, 10, SizeH);
        ButtonHistory.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Bottom, 2, SizeH);

        //���� ��������
        Setting.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        Setting.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 0, Height);

        //������ �����
        SettingBackBt.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 15, SizeH);
        SettingBackBt.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, 15, SizeH);

        //������ ������ 
        SettingBlock1.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock1.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock2.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock2.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock3.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock3.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock4.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock4.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock5.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock5.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock6.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock6.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);

        Bloack += Size + 10;

        SettingBlock7.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, 0, With);
        SettingBlock7.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Bloack, Size);
    }

    public void SettingClick()
    {
        SettingActive.SetActive(true);
    }

    public void SettingBackBtClick()
    {
        SettingActive.SetActive(false);
    }
}
