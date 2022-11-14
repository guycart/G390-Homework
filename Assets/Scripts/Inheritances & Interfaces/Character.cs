using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public virtual void Walk()
    {
        print($"the character is walking");
    }

    public virtual void Speak() => print($"Character is speaking");

    public void Punch(){}
}

public class Human : Character
{
    public override void Speak()
    {

    }
    public override void Walk()
    {
        base.Walk();
        print($"Human is walking");
    }

}