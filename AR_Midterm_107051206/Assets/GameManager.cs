using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("太空人")]
    public Transform play1;
    [Header("女人")]
    public Transform play3;

    [Header("太空人動畫元件")]
    public Animator aniplay1;
    [Header("女人動畫元件")]
    public Animator aniplay3;



    private void Start()
    {
        print("開始事件執行中");
    }
    private void Update()
    {
        print("更新事件");
        
    }

    public void run()
    {
        print("跑步");
        aniplay1.SetTrigger("跑步");
        aniplay3.SetTrigger("跑步");
    }
    public void walk()
    {
        print("走路");
        aniplay1.SetTrigger("走路");
        aniplay3.SetTrigger("走路");

    }
    public void PlayAnimation(string aniName)
    {
        print(aniName);
        aniplay1.SetTrigger(aniName);
        aniplay3.SetTrigger(aniName);

    }

}

