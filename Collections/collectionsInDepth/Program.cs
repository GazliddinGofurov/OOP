using System ;
using System.Collections;
namespace WorkingWithCollections
{
    class Program
    {
        static void Main (string[] args)
        {
                /*
                Car car1 = new Car();
                car1.Make = "Oldsmobile";
                car1.Model = "Cutlas Supreme";
                car1.VIN = "A1";

                Car car2 = new Car();
                car2.Make = "Geo";
                car2.Model = "Prism";
                car2.VIN = "A2";

                Book b1 = new Book();
                b1.Author = "Robert Tabor";
                b1.Title = "Microsoft .NET XML Web Services";
                b1.ISBN = "0-000-00000-0";
                */
                

                /*
                // ArrayList are dynamically sized,
                // Cool Features sorting, remove items

                ArrayList myArrayList =  new ArrayList();
                myArrayList.Add(car1);
                myArrayList.Add(car2);
                myArrayList.Add(b1);
                myArrayList.Remove(b1);

                foreach(Car car in myArrayList){
                    Console.WriteLine(car.Make);
                    
                }
                */

                /*
                // List<T>
                List<Car>myList =  new List<Car>();
                myList.Add(car1);
                myList.Add(car2);
                //myList.Add(b1);

                foreach(Car car in myList){
                    Console.WriteLine(car.Make);
                    
                }
                */

                // Object Intitializer
                // No need Constructor
                
                Car car1 =  new Car (){Make = "BMW", Model = "X7", VIN = "C2"};
                Car car2 =  new Car(){Make = "Toyota", Model = "4Runner", VIN = "D4"};

                // Colection Initializer
                // List<Car> cars =  new List<Car>()
                // {
                //     new Car{Make = "BMW", Model = "X7", VIN = "C2"},
                //     new Car{Make = "Toyota", Model = "4Runner", VIN = "D4"}
                // };

                // Dictionary <TKey, TValue>
                Dictionary<string, Car> myDictionary =  new Dictionary<string, Car>();
                myDictionary.Add(car1.VIN, car1);
                myDictionary.Add(car2.VIN, car2);

                Console.WriteLine(myDictionary["A2"].Make);


                Console.ReadLine();
        }
    }
}