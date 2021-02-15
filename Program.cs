using System;
using System.Collections.Generic;

namespace Army
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase.ukraine.AddChild(new Composite("Kyiv"));
            DataBase.ukraine.AddChild(new Composite("Kharkiv"));

            DataBase.ukraine.AddMan(new ManProxy("John Cena"), new List<string>() {"Kharkiv", "village" });
            DataBase.ukraine.AddMan(new ManProxy("Vasya Joe"), new List<string>() { "Kyiv" });
            DataBase.ukraine.AddMan(new ManProxy("Vova Zelen"), new List<string>() { "Kherson", "Zaliznyy port" });
            DataBase.ukraine.AddMan(new ManProxy("Egor Bugor"), new List<string>() {});

            DataBase.doctor.setNextHandler(new Ophthalmologist());
            DataBase.doctor.setNextHandler(new Neurologist());
            DataBase.doctor.setNextHandler(new Traumatologist());
            DataBase.doctor.setNextHandler(new Cardiologist());

            Cui.Show();

        }
    }
}
