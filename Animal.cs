using System;
namespace Animals
{
  abstract class Animal
  {
      protected string name;

      protected string lastName;

      public string LastName  {
            get => $"Mr. {lastName}"; 
            set => lastName = value;
       }

      protected string fullName;
      public abstract void MakeSound();

      public string GetFullName() {
          return $"{this.name} {this.lastName}";

      }
  }
}