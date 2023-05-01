using System; 

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();  // aqui creamos la variable para la lista "trabajos" y la inicializamos para poder usarla.
    
    public void Display()  // añadimos metodo para mostrar los detalles
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }

}

