namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

       public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } //makes it read only. can only be set in the constructor
    }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }   
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

    public Member(int memberId, string name, string address, int phone)
    {
        this.MemberId = memberId;
        this.Name = name;
        this.Address = address;
        this.Phone = phone;
    }

    public void DisplayInfo()
    {
        // Print the member details to the console
        Console.WriteLine($"Member ID: {MemberId}");
        Console.WriteLine($"Member Name: {Name}");
        Console.WriteLine($"Member Address: {Address}");
        Console.WriteLine($"Member Phone: {Phone}");
    }
}
}
