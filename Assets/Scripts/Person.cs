using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    //Variavel recebida pela cena anterior 
    //setando a quantidade de meliante que jogaram
    public static int modo = 4;

    public static GameObject vitoria;

    //Mantem a seleção dos personagens entre as cenas
    public static GameObject[] playersSelect = new GameObject[modo];

    // Backend

    public static GameObject[] playersBack = playersSelect;

    //Mantem a seleção dos personagens entre as cenas
    public static GameObject[] playersDeath = new GameObject[modo];
}
