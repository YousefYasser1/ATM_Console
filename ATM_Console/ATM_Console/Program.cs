// See https://aka.ms/new-console-template for more information
using ATM_Console;

Console.WriteLine("Hello, World!");


//It is For Testing , Suppose it a Data base
List<User> users = new List<User>();
users.Add(new User(1 , "Ahmed Omer" , 50_000 , 1234));
users.Add(new User(2 , "Eman Mohamed" , 40_000, 4567));
users.Add(new User(3 , "Ali Mohamed" , 30_000, 7899));
users.Add(new User(4 , "Farah Amr" , 20_000, 4321));
users.Add(new User(5 , "Omer Ahmed" , 10_000, 6541));



Main_Fuction.MainFunction(users);
