using System;
//Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
namespace namu{
    class first{
        static void Main(string[] args){
        Console.WriteLine("How many people do you want to calculate the bmi ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i=1;i<=x;i++){
                Console.WriteLine("Enter the person details enter kg first and meter second");
                int kg = Convert.ToInt32(Console.ReadLine());
                double meter = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(kg/Math.Pow(meter,2));
            }
            Console.WriteLine("Thank you so much");
        }
    }
}