/* Instead of using the properties method. We want to give users a more interactive lab. Can up performance.
 * Therefore, the following should be done.
 * TODO: 
 * 1. Remove this file.
 * 2. Use Blender or any animation program and cut the measuring portion of the calipers into two components.
 * 3. Program the measuring portion of the calipers so you can move it up or down.
 * 4. See CollisionProperties.cs.
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthProperties : MonoBehaviour
{
    public float length;
    // Set to Meters at the moment.
    // You can change any of the values by going to any tensile with this script.
    // Should only be set to any object that has collision.
    public float width;
    public float height;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // To get Length from properties, inheritance is used to call value.
    public float getLength()
    {
        return length;
    }
}
