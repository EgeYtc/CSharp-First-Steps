using System.Diagnostics;

namespace _24_Hospital_Queue_System
{
    internal class Program
    {
        struct Patient
        {
            public string Name;
            public int Age;
            public bool Priority;

            public Patient(string name, int age, bool priority)
            {
                Name = name;
                Age = age;  
                Priority = priority;
            }
        }
        static void Main(string[] args)
        {

            Queue<Patient> hospitalQueue = new Queue<Patient>();

            Patient patient1 = new Patient("John", 30, true);
            Patient patient2 = new Patient("Alice", 25, false);
            Patient patient3 = new Patient("Bob", 40, false);

            hospitalQueue.Enqueue(patient1);
            hospitalQueue.Enqueue(patient2);
            hospitalQueue.Enqueue(patient3);

            Patient firstLine = hospitalQueue.Peek();

            Debug.WriteLine($"Name: {firstLine.Name}, Age: {firstLine.Age}, Priority: {firstLine.Priority}");

            hospitalQueue.Dequeue();
            firstLine = hospitalQueue.Peek();
            Debug.WriteLine($"Name: {firstLine.Name}, Age: {firstLine.Age}, Priority: {firstLine.Priority}");

            Patient patient4 = new Patient("Charlie", 35, false);
            hospitalQueue.Enqueue(patient4);
            Debug.WriteLine($"Queue Count: {hospitalQueue.Count()}");
        }
     
    }
}
