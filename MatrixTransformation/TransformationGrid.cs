/**************************************************
writer：
time：#CreateTime#
name：
function：
**************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationGrid : MonoBehaviour
{
    List<Transformation> transformations;
    // Start is called before the first frame update
    void Awake() {
        transformations = new List<Transformation>();
    }
    void Update()
    {
        //GetComponent<Transformation>(transformations);
        
    }
}
