using System;
namespace ClassMember
{
    class Car{
        string model;
        string Owner;
        int year;
    
    static void Main(string[] arg){
        Car Toyota = new Car();
        Toyota.model = "star";
        Toyota.Owner = "Emon";
        Toyota.year = 2025;


        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.Owner = "Emon";
        Ford.year = 2024;

        Console.WriteLine(Ford.Owner);
    }
    
}
}

