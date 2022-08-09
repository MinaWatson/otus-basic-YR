using UnityEngine;
using System.IO;
using System;

public class CsharpBasic : MonoBehaviour
{
[SerializeField] bool first; // данные можно менять в инспекторе
[SerializeField] byte second;
[SerializeField] float third;
[SerializeField] double fourth;
[SerializeField] long fifth;
[SerializeField] char sixth;
[SerializeField] int seventh;
private void ConvertType()
{
    first = true; // проставляем галку в Unity
    second = Convert.ToByte(first); // Convert нужен, чтобы сделать преобразование типа bool в byte
    third = sixth; // неявное преобразование
    fourth = 127;
    fifth = Convert.ToSByte(fourth); // преобразование double в long
    sixth = 'a';
    seventh = Convert.ToInt32(fifth); // преобразование long в int
}
public void Strings()
{
    string s1 = Convert.ToString("Bool " + first);
    string s2 = Convert.ToString("Byte " + second);
    string s3 = Convert.ToString("Float " + third);
    string s4 = Convert.ToString("Double " + fourth);
    string s5 = Convert.ToString("Long " + fifth);
    string s6 = Convert.ToString("Char " + sixth);
    string s7 = Convert.ToString("Int " + seventh);
    string[] values = new string[] { s1, s2, s3, s4, s5, s6, s7};
    string s8 = string.Join("; ", values);
    Debug.Log(s8); // выводим в консоль

    string path = Application.dataPath + "/Basic.txt"; // файл в папке Assets к проекту
    if (!File.Exists(path)) // уже есть файл в папке? тогда делаем запись 
    {
        File.WriteAllText(path, s8);
    }
}
private void Start()
{
    ConvertType();
    Strings();    
    var time = new DateTime();
    Debug.Log(time); // время и дата в консоль
}
}