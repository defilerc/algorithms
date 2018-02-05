using System;

public class Person
{
    int age;

    public Person(int initialAge)
    {

        if (initialAge < 0) {
            Console.WriteLine("Age is not valid, setting age to 0.");
        }

        this.age = initialAge;
    }
}