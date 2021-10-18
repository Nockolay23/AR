using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public Image img;

    int With;
    int Height;

    public int SizeImg;
    public int Scene;

    public float timer, Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene(Scene);

        With = Screen.width;
        Height = Screen.height;

        img.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, With /2 - SizeImg / 2, SizeImg);
        img.rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, Height / 2 - SizeImg / 2, SizeImg);

        timer = Cooldown;
    }

    private void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
        else if (timer <= 0)
            SceneManager.LoadScene(Scene);
    }
}
