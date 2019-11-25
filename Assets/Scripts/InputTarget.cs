using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface InputTarget :  IEventSystemHandler
{
    void moveForward();
    void turnLeft();
    void turnRight();
    void stop();
    void push();
    void superPush();
}
