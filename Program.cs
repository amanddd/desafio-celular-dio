﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("================= Meu Iphone ====================");
System.Console.WriteLine();
Iphone meuIPhone = new Iphone("22132213", "Iphone 12", "43546576574", 64);
meuIPhone.InstalarAplicativo("Tinder");

System.Console.WriteLine();

System.Console.WriteLine("================= Meu Nokia ====================");
System.Console.WriteLine();
Nokia meuNokia = new Nokia("40028922", "Nokia Tijolão", "12342313414", 32);
meuNokia.InstalarAplicativo("Snake");