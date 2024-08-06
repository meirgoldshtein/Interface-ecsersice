using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ecsersice
{
    internal interface IPerson
    {
        string GetFullName();
        int GetAge();
    }

    public class Person : IPerson
    {
        protected readonly string Role;
        protected string FirstName { get; set; }

        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        public Person(string role, string firstName, string lastName, DateTime birthDate)
        {
            Role = role;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        
        public DateTime GetBirthDate()
        {
            return BirthDate;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            return CalculatAge();
        }

        private int CalculatAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }



    public class Student : Person
    {
        public Student(string role, string firstName, string lastName, DateTime birthDate) : base(role, firstName, lastName, birthDate)
        {

        }
        public string GetRole()
        {
            return GeneratorRole();
        }

        private string GeneratorRole()
        {
            return Role;
        }
    }



    public class Teacher : Person
    {
        public Teacher(string role, string firstName, string lastName, DateTime birthDate) : base(role, firstName, lastName, birthDate)
        {

        }
        public string GetRole()
        {
            return GeneratorRole();
        }

        private string GeneratorRole()
        {
            return Role;
        }

    }

    public interface IRepository<T>
    {
            public void Add(T item);
            public void Remove(T item);
            public T FindById(int id);
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserRepository : IRepository<User>
    {
        List<User> list = new List<User>();
        public void Add(User item)
        {

        }
        public void Remove(User item)
        {

        }
        public User FindById(int id)
        {
            return new User
            {
                Id = id
            };
        }

        public List<User> GetAllUsers()
        {
            return list;
        }

    }


    public class ProductRepository : IRepository<Product>
    {
        List<Product> list = new List<Product>();
        public void Add(Product item)
        {

        }
        public void Remove(Product item)
        {

        }
        public Product FindById(int id)
        {
            return new Product
            {
                Id = id
            };
        }

        public List<Product> GetAllUsers()
        {
            return list;
        }

    }


    public interface Imoveable
    {
        public void MoveForward();
        public void MoveBackward();
    }

    public interface IFlyable
    {
        public void Flyoff();
        public void Land();
    }

    public class FlyingCar : Imoveable, IFlyable
    {
        public void MoveForward()
        {
        }
        public void MoveBackward()
        {
        }
        public void Flyoff()
        {
        }
        public void Land()
        {
        }

        public void StartEngine()
        {
            MoveForward();
            Flyoff();

        }

        public void StopEngine()
        {
            MoveBackward();
            Land();
        }
    }
}

