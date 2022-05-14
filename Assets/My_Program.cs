using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class My_Program : MonoBehaviour
{
        void Start()
        {
            bool loop = true;
            string str;

            bool loopJuegos = true;


            //while (loop)
            //{
                //while (loopJuegos)
               // {
                    Debug.Log("Juegos de Mesa");
                    Debug.Log("1 - Monopolio S/.55");
                    Debug.Log("2 - Jenga S/.31");
                    Debug.Log("3 - Twister S/.79");

                    str = "1"; //Console.ReadLine();
                    switch (str)
                    {
                        case "1":
                            //Console.Clear();
                            Debug.Log("Monopolio");
                            Debug.Log("Este juego es para 3 a 4 Jugadores máximos");
                            break;

                        case "2":
                            //Console.Clear();
                            Debug.Log("Jenga");
                            Debug.Log("Este juego es para 2 a 8 Jugadores máximos");
                            break;

                        case "3":
                            //Console.Clear();
                            Debug.Log("Twister");
                            Debug.Log("Este juego es para 3 a 4 Jugadores máximos");
                            break;

                    }
                    Debug.Log("Regresar? (S/N)");
                    str = "2";//Console.ReadLine();
                    if (str == "S")
                        loopJuegos = true;
                    //Console.Clear();
                    if (str == "N")
                        loopJuegos = false;



                    //Console.Clear();
                }
        }