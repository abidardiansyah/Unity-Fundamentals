using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : AgentBehaviour
{
    bool activeSteering;
    Quaternion lastRotation;
    public override void Update()
    {
        if(Vector3.Distance(target.transform.position,this.gameObject.transform.position)<10f)
        {
        	activeSteering =true;
        	this.gameObject.transform.LookAt(target.transform);
        	lastRotation=this.gameObject.transform.localRotation;
    	}
    	else
    	{
        	this.gameObject.transform.localRotation=lastRotation;
        	activeSteering=false;
        }
        base.Update();
    }

    // Update is called once per frame
    public override Steering GetSteering()
    {
    	Steering steering=new Steering();
        if(activeSteering)
        {
        	steering.linear=target.transform.position-transform.position;
        	steering.linear.Normalize();
        	steering.linear=steering.linear*agent.maxAccel;
    	}
    	return steering;
    }
}
