using ConsoleApp1;

Console.WriteLine("İsminizi Giriniz: ");
string name = Console.ReadLine();

Console.WriteLine("Yaşınızı Giriniz: ");
int yas = int.Parse(Console.ReadLine());

Person p = new Person(yas, name);

