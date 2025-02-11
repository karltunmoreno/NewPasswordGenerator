// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();

Console.WriteLine(password);



