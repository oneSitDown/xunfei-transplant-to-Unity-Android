using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    /// <summary>
    /// 场景上的文本框用来显示android发送过来的内容
    /// </summary>
    public Text text;

    /// <summary>
    /// android原生代码对象
    /// </summary>
    AndroidJavaObject _ajc;

    void Start()
    {
        //通过该API来实例化导入的arr中对应的类
        _ajc = new AndroidJavaObject("com.iflytek.mscv5plusdemo.AsrDemo");
    }

    void Update()
    {

    }

    /// <summary>
    /// 场景上按点击时触发该方法
    /// </summary>
    public void OnBtnClick()
    {
        //通过API来调用原生代码的方法
        bool success = _ajc.Call<bool>("InitAsr");
        if (true == success)
        {
            //请求成功
        }
    }

    public void OnBtnClick2()
    {
        //通过API来调用原生代码的方法
        bool success = _ajc.Call<bool>("Buildsyntax");
        if (true == success)
        {
            //请求成功
        }
    }

    public void OnBtnClick3()
    {
        //通过API来调用原生代码的方法
        bool success = _ajc.Call<bool>("StartRecognize");
        if (true == success)
        {
            //请求成功
        }
    }

    /// <summary>
    /// 原生层通过该方法传回信息
    /// </summary>
    /// <param name="content"></param>
    public void FromAndroid(string content)
    {
        text.text = content;
    }
}