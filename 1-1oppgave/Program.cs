// See https://aka.ms/new-console-template for more information
//Lag en applikasjon hvor vi lager noen personer med noen attributter, deretter lag en meny hvor man kan 1) se på personer 2) avslutte program.
using System.ComponentModel.Design;

string[] dataBase = { "Martin", "Rebecka", "Marie", "Ellie" };
List<string> People = new List<string> { "Martin" , "Rebecka", "Marie", "Ellie" };
People.Add("Terje");
//var newPerson = new Person("Kompis");

while(true){
    Meny();
    InputFunc();
}

void InputFunc(){
    var userInput = Console.ReadLine();

    // hvis input == 1 -> Vise personer (egen funksjon?)
    if(userInput == "1")
    {
        ShowPeople();
    }
    else if (userInput == "2")
    {
        AddPeople(); //hvis samme navn i
    }
    else
    {
        Exit();
    }

    // hvis input == 2 -> avslutte
}   

void Meny()
{   
    Console.WriteLine("Welkommen Til The Get Database!");
    Console.WriteLine("1) Se personer");
    Console.WriteLine("2) Legg til person");
    Console.WriteLine("3) Avslutt personer");
    
}

void ShowPeople()
{
    for (var i = 0; i < People.Count; i++)  // skriver ut alt i dataBase
    {
        Console.WriteLine(People[i]);
    }
}

void AddPeople()
{
    People.Add(Console.ReadLine());
}
void Exit()
{
    Environment.Exit(0);
}

// Welkommen TIl The Get Database!
// Valg: 
// 1) Se personer
// 2) Avslutt program

// Martin
// Rebecka
// ...

// Welkommen TIl The Get Database!
// Valg: 
// 1) Se personer
// 2) Avslutt program