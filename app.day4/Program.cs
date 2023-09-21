using App;
using System;
namespace app {
    public class program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("how many trainees ");
            int count =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of Trainee");
            //int traineeNo = int.Parse(Console.ReadLine());
            Trainee[] trainees = new Trainee[count];
            Arr arr = new Arr(count);
            for (int i = 0; i < count; i++)
            {
                trainees[i] = new Trainee();
                Console.WriteLine("Enter Name");
                trainees[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Id");
                trainees[i].Id = int.Parse(Console.ReadLine());
                arr.Add(trainees[i]);
               
            }
            foreach (Trainee trainee in arr)
            {
                Console.WriteLine(trainee);
            }
            arr.Remove(0);

            for(int i =0; i < arr.Count -1; i++)
                Console.WriteLine(arr[i]);



        }
    }
}



