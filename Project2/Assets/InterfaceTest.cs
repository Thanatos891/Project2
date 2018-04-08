using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTest : InheritanceT,  ITest
{
    //overwrittent function for inheritated function from InheritanceTest class, changing what is debugged.
    //can be used in AI building, where all AI have a base function to run off of, but can be overwritten
    // to do other things when that function is activated. 
    public override void Test1()
    { Debug.Log("Test 1: InterfaceTest activated: CHILD FUNCTION"); }
    

    //running the base class of the inheritatenceTest function Test2();
    public override void Test2()
    {
        base.Test2();
    }

    public void Test3()
    {
        Debug.Log("Interface function: Test3 activated.");
    }
    public void Test4()
    {
        Debug.Log("Interface function: Test4 activated.");
    }

}


// Inheritance abstract class that InterfaceTest will inherit from.
// Using virtuals allows base parent functions to run, but also allows children to override them. 
// functions inside of the parents Class are referred to as base functions, as they run normal if you don't
// change anything in them. 
public abstract class InheritanceT
{
    public virtual void Test1()
    {
        Debug.Log("Test 1: Inheritance activated, PARENT FUNCTION");
    }
      public virtual void Test2()
    {
        Debug.Log("Test 2: Inheritance activated, PARENT FUNCTION");
    }
   
}

//Interface
public interface ITest
{
    void Test3();
    void Test4();
}
