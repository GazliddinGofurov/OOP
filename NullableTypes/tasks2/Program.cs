using System;
namespace _tasks2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Dastlabki profil ma'lumotlari (boshlang'ich holat)
        UserProfile user = new UserProfile
        {
            Name = "Ali",
            Age = 20,
            Address = "Toshkent",
            Hobbies = null // Hali xobbilari yaratilmagan (null)
        };

        // 2. Yangilanayotgan ma'lumotlar (DTO)
        ProfileUpdatedTo dto = new ProfileUpdatedTo
        {
            NewName = null, // Ismi o'zgarmaydi (eski ismi qoladi)
            NewAge = 25,    // Yoshi o'zgaradi
            NewAddress = null,
            NewHobbies = new List<string> { "Dasturlash", "Shaxmat" } // Yangi xobbilar
        };

        // 3. Metodni chaqirish
        UpdateProfile(user, dto);

        // 4. Natijani konsolga chiqarib tekshirish
        Console.WriteLine($"Ism: {user.Name}");
        Console.WriteLine($"Yosh: {user.Age}");
        Console.WriteLine($"Manzil: {user.Address}");
        Console.WriteLine($"Xobbilar: {string.Join(", ", user.Hobbies ?? new List<string>())}");
    }
            
    

    static void UpdateProfile(UserProfile current, ProfileUpdatedTo updates)
    {
       
       current.Name = updates.NewName??current.Name ?? "Anonymous";

       if(updates.NewAge > 0)
            {
                current.Age = updates.NewAge;
            }

        if (!string.IsNullOrEmpty(updates.NewAddress))
            {
                current.Address =  updates.NewAddress;
                
            }

        if (updates.NewHobbies != null)
        {
            current.Hobbies ??= new List<string>();
            current.Hobbies.AddRange(updates.NewHobbies);
        }
            
    }
    }
}