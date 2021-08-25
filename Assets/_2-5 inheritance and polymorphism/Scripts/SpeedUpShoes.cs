using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpShoes : ItemBase2D
{
    public override void Activate()
    {
        FindObjectOfType<PlatformerPlayerController2D>().m_jumpSpeed=30;

    }
}
