using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeMana : MonoBehaviour
{

    public float life;
    public float mana;
    private float lifeRegen;
    private float manaRegen;
    private float lifeTotal;
    private float manaTotal;

    void Start()
    {
        mana = 100;
        life = 250;
        lifeRegen = 0.9f;
        manaRegen = 0.4f;
        manaTotal = mana;
        lifeTotal = life; 
    }

    void Update(){

        if(mana < manaTotal){
            mana += manaRegen;
            if(manaTotal - mana < manaRegen){
                mana = manaTotal;
            }
        }
        if(life < lifeTotal){
            life += lifeRegen;
            if(lifeTotal - life < lifeRegen){
                life = lifeTotal;
            }
        }
        

    }
}
