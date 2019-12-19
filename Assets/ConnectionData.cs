﻿using UnityEngine;

public class ConnectionData : MonoBehaviour
{
  [HideInInspector]
  public string selectedIP;
  [HideInInspector]
  public int selectedPort;

  public int portOut;
  public int portIn;
  public string domeIP;
  public string weIP;
  public string smIP;


  void Start()
  {
    // set default values
    domeIP = "141.54.159.119";
    weIP = "192.168.2.100";
    smIP = "192.168.178.37";
    selectedPort = portOut;
  }
}
