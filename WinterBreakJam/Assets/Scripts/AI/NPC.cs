using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class NPC : AIPath, ITargetable, IAI
{
    bool currentlySelected = false; //Testing base functionality
    [SerializeField] protected Transform m_transformTarget = null;

    protected override void Awake()
    {
        base.Awake();

        //TODO: Remove this, temp line. 
        //m_transformTarget = GameObject.Find("TEST_TARGET").transform;//null;
    }

    protected override void Update()
    {
        base.Update();

        AITick();
    }

    public void SetTargetTransform(Transform target = null)
    {
        m_transformTarget = target;
    }

    public void SetTargetPosition(Vector3 target)
    {
        destination = target;
    }

    #region Targetable_Functionality
    public void OnHit()
    {
        //Handle Hit Functionality
    }

    public void OnSelectBegin()
    {
        currentlySelected = true;
    }

    public void OnSelectEnd()
    {
        currentlySelected = false;
    }
    #endregion

    #region AI_Functionality
    public void AITick()
    {
        if(m_transformTarget != null)
        {
            destination = m_transformTarget.position;
        }
    }

    public void PathFind()
    {

    }
    #endregion
}
