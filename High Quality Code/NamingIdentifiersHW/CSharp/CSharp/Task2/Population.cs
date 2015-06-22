namespace CSharp.Task2
{
    using System;

    public class Population
    {  
        public void CreatePerson(int inputNumber)
        {
            Person newPerson = new Person();
            newPerson.Age = inputNumber;
            if (inputNumber % 2 == 0)
            {
                newPerson.Name = "Georgi";
                newPerson.Gender = Gender.male;
            }
            else
            {
                newPerson.Name = "Maria";
                newPerson.Gender = Gender.female;
            }
        }
    }
}