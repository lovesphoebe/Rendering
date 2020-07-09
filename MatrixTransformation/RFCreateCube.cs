/**************************************************
writer：zzhaozhuo
time：#CreateTime#
name：RFCreateCube
function：矩阵变换测试
**************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RFCreateCube : MonoBehaviour
{
    public Transform cube;

    public int cubeResolution = 5;

    Transform[] grid;
    void Start()
    {
        grid = new Transform[cubeResolution * cubeResolution * cubeResolution];
        for(int i = 0,z = 0; z < cubeResolution; z++)
            for(int y = 0; y < cubeResolution; y++)
                for(int x = 0; x < cubeResolution; x++, i++){
                    grid[i] = CreateGrid(x, y, z);
                }
    }
    Transform CreateGrid(int x, int y, int z){
        Transform point = Instantiate<Transform>(cube);
        point.localPosition = GetCoordinates(x, y, z);
        point.GetComponent<MeshRenderer>().material.color = new Color(
            (float)x / cubeResolution,
            (float)y / cubeResolution,
            (float)z / cubeResolution
        );
        return point;
    }
    Vector3 GetCoordinates(int x, int y, int z){
        // return new Vector3(
        //     x - (cubeResolution - 1) * 0.5f,  
        //     y - (cubeResolution - 1) * 0.5f,
        //     z - (cubeResolution - 1) * 0.5f
        // );
        return new Vector3(2*x,2*y,2*z);
    }

    // Update is called once per frame
}
