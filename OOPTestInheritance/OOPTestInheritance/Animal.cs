using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTestInheritance;

public class Animal
{
    public int Id { get; set; }
    public string? Color { get; set; }
    public int? Age { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set;}

}
public interface IButterfly
{
    void Fly();
}
public class Butterfly: Animal, IButterfly
{
    public void Fly()
{
    Console.WriteLine("The butterfly can fly");
}
}
