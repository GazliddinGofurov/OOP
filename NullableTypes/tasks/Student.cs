// class Student
// {
//     public string? name;
//     public int? age;
//     public double? score;

//     public Student()
//     {
        
//     }




//     public void PrintStudent(string? name, int? age, double? score)
//     {
//         Console.WriteLine($"Name: {name ?? "unknown"}");
//         Console.WriteLine($"Age: {age ?? 0}");
//         Console.WriteLine($"Score: {score ?? 0}");
//     }
// }

namespace _task{
class Student
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public double? Score { get; set; }
    
  
  
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name ?? "Unknown"}");
        Console.WriteLine($"Age: {Age ?? 0}");
        Console.WriteLine($"Score: {Score ?? 0}");
    }
}

}