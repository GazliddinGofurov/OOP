namespace _tasks2
{
    class UserProfile
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public List<string>? Hobbies { get; set; } 

    }

    class ProfileUpdatedTo
    {
        public string? NewName { get; set; }
        public int? NewAge { get; set; }
        public string? NewAddress { get; set; }
        public List<string>? NewHobbies { get; set; } 
    }

    

}