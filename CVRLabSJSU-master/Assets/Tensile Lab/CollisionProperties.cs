/* We want to add a system that allows a user to move the caliper's measuring portion.
 * To do so, we should make the caliper's measuring portion movable. Using the Steam VR controllers.
 * TODO:
 * 1. Make the the caliper movable.
 * 2. Set the Steam VR controllers to allow it to control the caliper.
 * 3. Create a linear algorithm that will set the value at lengthOutput to a specific measurement.
 * 4. (y = mx + b) LengthOutput = WhereTheCaliperIsAt * theMeasurementOffset + deviation(can be 0)
 * 5. The rest of the code does not need to be change unless the UI needs changing.
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionProperties : MonoBehaviour
{
    public GameObject FloatingText;
    private float lengthOutput;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        getlengthOutput(); 
    }
    // Should only be used for the Calipers.
    private void OnCollisionStay(Collision ObjectMeasure)
    { 
        // TODO: Set The collision to be dynamic
        GameObject Object = ObjectMeasure.gameObject;
        if (Object.GetComponent<LengthProperties>().getLength() > 0)
        { 
        // Debug
        Debug.Log("Hit Detected");
        lengthOutput = Object.GetComponent<LengthProperties>().getLength();
        }
        else lengthOutput = 0;
    }
    public void getlengthOutput()
    {
        if (lengthOutput <= 0) FloatingText.GetComponent<TextMesh>().text = "???";
        else FloatingText.GetComponent<TextMesh>().text = lengthOutput.ToString();
    }
}
