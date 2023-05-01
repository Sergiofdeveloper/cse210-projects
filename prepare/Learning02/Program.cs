using System;

class Program
{
    static void Main(string[] args)
    {
        ///Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();  // aqui creamos una instancia llamando primero a la clase y despues la damos el nombre deseado.
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear= 2019;
        job1._endYear = 2022;

        Job job2 = new Job();  
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear= 2022;
        job2._endYear = 2023;

        //Console.WriteLine(job1._company); // asi mostramos la empresa del trabajo 1
        //Console.WriteLine(job2._company); // asi mostramos la empresa del trabajo 2

        //job1.Display(); // de esta forma llamamos a esta funcion que pertenece a la instancia job1
        //job2.Display(); // de esta forma llamamos a esta funcion que pertenece a la instancia job2

        Resume resume1 = new Resume();  // creamos una instancia para la classe resume que se llama resume1
        resume1._name = "Allison Rose";
        resume1._jobs.Add(job1);  // aqui añadimos usando .Add el trabajo 1
        resume1._jobs.Add(job2);  // aqui añadimos usando .Add el trabajo 2

        resume1.Display();


    }
}