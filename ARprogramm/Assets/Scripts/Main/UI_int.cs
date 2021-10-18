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

    int With;
    int Height;

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
    }
}
