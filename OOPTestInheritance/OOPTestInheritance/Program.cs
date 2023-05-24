using OOPTestInheritance;

Butterfly butterfly = new Butterfly();
Database database = new Database();

#region data into butterfly

//butterfly.Id = Convert.ToInt32(Console.ReadLine()); --> assigned by default.
Console.WriteLine("What color is your butterfly?");
butterfly.Color = Console.ReadLine();
Console.WriteLine("How old is your butterfly?");
butterfly.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Whats the name of the butterfly?");
butterfly.Name = Console.ReadLine();
Console.WriteLine("Whats the first name of the butterfly?");
butterfly.FirstName = Console.ReadLine();
Console.WriteLine("Whats the last name of the butterfly?");
butterfly.LastName = Console.ReadLine();
#endregion


Console.WriteLine("Is it a good butterfly? \nY: It was a good butterfly and it will be saved to the database\nN: It was a bad butterfly and will be deleted from the database");

var input = Console.ReadKey();
switch (input.Key)
{
    case ConsoleKey.Y:
        database.GoodButterfly = true;
        
        break;

    case ConsoleKey.N:
        database.GoodButterfly = false;
        break;
}


