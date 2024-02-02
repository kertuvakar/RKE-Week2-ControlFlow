// See https://aka.ms/new-console-template for more information
//rakendub küsib kasutja käest tema sugu (m/f)
//rakendus palub kasutajal sisestada oma perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"
using System;

Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine());//loeb sisse sõne ja muudab selle chariks ja salvestab selle üheks andmeuhikuks
Console.WriteLine("Please, enter your last name");
string userLastName = Console.ReadLine();   

if (userGender == 'm')
{
    Console.WriteLine($"Welcome Mr. {userLastName}!");
}

else if (userGender == 'f')//siin ei ole kirjeldatud, mida teha kui vastus on f. On vaja järgmist rida
{
    Console.WriteLine($"Welcome Ms. {userLastName}!");
}
//Aga kui kasutaja sisestab muu tähe
else 
{
   Console.WriteLine($"Welcome {userLastName}!");
}
