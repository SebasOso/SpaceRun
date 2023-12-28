using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomOne : MonoBehaviour
{
    public ButtomsManager manager;

    public void One()
    {
        manager.HandleButtonClick("1");
    }
    public void Two()
    {
        manager.HandleButtonClick("2");
    }
    public void Three()
    {
        manager.HandleButtonClick("3");
    }
    public void Four()
    {
        manager.HandleButtonClick("4");
    }
    public void Five()
    {
        manager.HandleButtonClick("5");
    }
    public void Six()
    {
        manager.HandleButtonClick("6");
    }
    public void Seven()
    {
        manager.HandleButtonClick("7");
    }
    public void Eight()
    {
        manager.HandleButtonClick("8");
    }
    public void Nine()
    {
        manager.HandleButtonClick("9");

    }
    public void Zero()
    {
        manager.HandleButtonClick("0");
    }
}
