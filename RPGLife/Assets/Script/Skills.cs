using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    
    private int[] levelSkill;
    private string[] nameSkill;
    private float[] xpSkill;
    private float[] upSkill;
    
    void Start()
    {
        nameSkill = new string[]{"lumberjack","miner","crafter","combat"};
        levelSkill = new int[]{0,0,0,0};
        xpSkill = new float[]{0,0,0,0};
        upSkill = new float[]{100f,100f,100f,100f};
    }

    void Update()
    {
        //test
        if(Input.GetKeyDown(KeyCode.V)){
            xpSkill[1] += 1010f;
            xpSkill[3] += 1170f;
            CheckXp();
        }

    }

    void CheckXp(){
        for(int p = 0; p < 4; p++){
            
            while(xpSkill[p] >= upSkill[p]){
                xpSkill[p] -= upSkill[p];
                upSkill[p] += upSkill[p] * 0.2f;
                levelSkill[p] += 1;
            }
            //Debug.Log(nameSkill[p] + "  " + levelSkill[p] + "  " + xpSkill[p] + "  " + upSkill[p]);
        }
    }
}
