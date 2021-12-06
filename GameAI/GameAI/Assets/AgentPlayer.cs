using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentPlayer : Agent
{
    
    public override void Update()
    {
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");
        velocity*=maxSpeed;
        Vector3 translation = velocity*Time.deltaTime;
        transform.Translate(translation,Space.World);
        transform.LookAt(transform.position+velocity);
        orientation=transform.rotation.eulerAngles.y;
    }
}
