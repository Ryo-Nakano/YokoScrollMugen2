
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cube;
    public GameObject stage;
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public Text longText;
    float length = 20;
    float cubeposition = 10;

    float instantiateposition =0;
    int count;




    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        longText.text = cube.transform.position.x.ToString();

        if (cube.transform.position.x > instantiateposition)
        {
            count = Random.Range(1, 5);
            if (count == 1)
            {
                
                Instantiate(stage, new Vector3(cubeposition + length , 0, 0), Quaternion.identity);
                count = 0;
                cubeposition += 30;
                instantiateposition += 30;

            }
            else if(count == 2){
                Instantiate(stage1, new Vector3(cubeposition + length, 0, 0), Quaternion.identity);
                count = 0;
                cubeposition += 30;
                instantiateposition += 30;
            }
            else if(count == 3){
                Instantiate(stage2, new Vector3(cubeposition + length, 0, 0), Quaternion.identity);
                count = 0;
                cubeposition += 30;
                instantiateposition += 30;
            }
            else{
                Instantiate(stage3, new Vector3(cubeposition + length, 0, 0), Quaternion.identity);
                count = 0;
                cubeposition += 30;
                instantiateposition += 30;

            }

        }


    }

	


}