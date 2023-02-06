//See on kommentaar
//rakendus küsib kasutajalt tema nime
//rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your neme: ");
string userName = Console.ReadLine();
Console.WriteLine("hello, "+userName+"!");

//string interpolation
Console.WriteLine($"hello, {userName}!");
