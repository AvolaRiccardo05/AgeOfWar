﻿// See https://aka.ms/new-console-template for more information
using AgeOfWar;

Console.WriteLine("Hello, World!");
Cavaliere cav1 = new Cavaliere(1000);
Cavaliere[] squadraRossa = new Cavaliere[100];
int[] a=new int[100];
for (int i = 0; i < 100; i++)
{
    a[i] = 10;
    squadraRossa[i] = new Cavaliere(1000);
    squadraRossa[i].Squadra = "squadra rossa";
}

