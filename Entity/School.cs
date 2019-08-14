namespace SchoolEntity

{
    class School
    {
        public School(string nameIn,int yearIn) => (Name,creationDate) = (nameIn,yearIn);
        public School(string nameIn, int yearIn, Type typesIn, string countryIn = "",string cityIn = "") 
        {
            (Name, creationDate) = (nameIn, yearIn);
            country = countryIn;
            city = cityIn;
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value.ToUpper();
            }
        }

        public int creationDate { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public Type types { get; set; }
        public Course[] courses { get; set; }

        public override string ToString() {
            return $"Name : {Name}, Type : {types} \n Country : {country}, City : {city}";
        }
    }
}