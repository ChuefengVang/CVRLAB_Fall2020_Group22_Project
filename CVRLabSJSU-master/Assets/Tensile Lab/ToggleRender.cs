/* 
 * Note that this should be used to trigger the broken tensile.
 * The way this is program is to allow any user to toggle the broken tensile by rendering the object(s).
 * See below on how to do so.
*/

/* Better method, Note you do not have to do so.
 * TODO: Use Delete function to delete AL2O3 specimen and enable two broken tensile on grabber.
 * TODO: Add particles and sound for the tensile animation. Should break the animation apart when you add particles.
 * This will allow two objects that can have their own properties and can be precisely measured by the calipers.
 * If you use this method, DO NOT create object and toggle rendering inside of the Grabber!
 * Instead toggle the render of the object and move it into the Grabber.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ToggleRender : MonoBehaviour
{
    // You can turn this into a dynamic array to turn off multiple objects.
    public GameObject ObjectBrokenTensile1;
    public GameObject ObjectBrokenTensile2;

    // Use to trigger animation once.
    bool animationTriggered = false;

    void Start ()
    {
        // Initialize trigger script and animation to false.
        this.enabled = false;
        this.GetComponent<ToggleRender>().enabled = false;
    }
    void Update ()
    {
    }

    // Use Collision Stay since the script will not trigger if entered.
    public void OnCollisionStay(Collision grabber)
    {
        // Checks if the object being collided with is the Grabber and the component is off, lever will trigger this to true.
        if (grabber.gameObject.name == "Grabber" && this.GetComponent<ToggleRender>().enabled == true)
        {
            // TODO: Replace this with actual time delay for both the lever and Grabber. Use the graph chart as a reference.
            // Could possibly remove the FOR LOOP as the animation has already been added. May need to adjust the animation a bit. 
            for (int i = 0; i < 5; i++)
            {
                // Time delay used to wait for lever and Grabber events.
            }
            // To disable seeing the object with the collision.
            // TODO: Delete/Derender object and place object where players cannot reach or see.
            // Do not spawn it falling under the map! Waste of computation resources as the item is constantly falling and being computed.
            this.GetComponent<MeshRenderer>().enabled = false;

            // Turns object visable.
            // TODO: Spawn items as one entity
            // When the user is about to touch it.
            // Change them to two objects into seperate entities. Then apply this method.
            // Make sure to place object to where players cannot see before teleporting object to grabber coordinate because
            // having this object in the Grabber will break collision.
            ObjectBrokenTensile1.GetComponent<MeshRenderer>().enabled = true;
            ObjectBrokenTensile2.GetComponent<MeshRenderer>().enabled = true;

            // Triggers the Tensile break animation once.
            if (animationTriggered == false)
            {
                ObjectBrokenTensile2.GetComponent<Animation>().Play("TensileBreak");
                animationTriggered = true;
            }
            // TODO: break the animation into two, add sounds, and maybe some particle affects.
        }
    }
}
/*
1. To enable this place the script into the specimen by adding components.
2. Set the two objects to the two broken tensile you want.
3. Make sure that the two broken tensile object's visibility is turned off in the initial state, by toggling MeshRenderer.
4. Go to lever, and add a script to "Lever Pressed" script.
5. Add "Al203 Specimen" as the object and set ToggleRender as the script to use.
6. In the drop down menu, select bool enabled, and set to true, checked.
You can copy this script and apply this to any other object by removing the Grabber string and using a different string.
You may render/derender multiple objects as well by replacing the Game Object to an array.
*/
