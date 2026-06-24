class Dasturchi: Employee
        {
            public string  Soha { get; set; }
            public Dasturchi(string firstName, string lastName, string citizenship ,double salary,string soha)
            :base(firstName,lastName,citizenship,salary)
            {
                Soha =  soha;
                
            }
            public override void Work()
            {
                Console.WriteLine($"{Soha} dasturchi is kod yozyapti.....");
            }

            public void dasturchiPrintInfo()
            {
                Console.WriteLine("\n======== DASTURCHI=========");
                base.PrintInfo();
                Console.WriteLine($"Maosh: {Salary}");
                Console.WriteLine($"Sohasi: {Soha}");
                
            }
        }