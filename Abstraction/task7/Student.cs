class Student : Person
        {
            public string Institution{ get; set;}
            public double  Scholarship { get; set; }
            public Student(string firstName, string lastName, string citizenship, string institution, double scholarship
            ):base(firstName,lastName,citizenship)
            {
                Institution = institution;
                Scholarship =  scholarship; 
            }
            

            public void PrintStudentInfo()
            {
                Console.WriteLine("\n======== STUDENT=========");
                base.PrintInfo();
                Console.WriteLine($"Talim Muassasi: {Institution}");
                Console.WriteLine($"Stipendiya: {Scholarship}");
            }

        }