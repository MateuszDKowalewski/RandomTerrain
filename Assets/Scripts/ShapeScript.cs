using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeScript : MonoBehaviour
{
    public float getValue(float x, float z) {
        return 7 * ( x / 5 ) * ( z / 5 ) / Mathf.Exp(( x / 5 ) * ( x / 5 ) + ( z / 5 ) * ( z / 5 ));
    }
}
