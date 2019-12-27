using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITargetable 
{
    void OnSelectBegin();
    void OnSelectEnd();

    void OnHit();
}
