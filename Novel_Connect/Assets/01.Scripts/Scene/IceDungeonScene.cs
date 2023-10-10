using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceDungeonScene : BaseScene
{
    public override void Init()
    {
        Debug.Log("아이스 던전 켜짐");
        Managers.Object.Player.Init(1, "Normal");
        Managers.Object.Player.SetPosition(new Vector3(-3.34899998f, -0.9f, 0));
        Managers.Screen.SetCameraTarget(Managers.Object.Player.trans);
    }

    public override void Clear()
    {

    }
}
