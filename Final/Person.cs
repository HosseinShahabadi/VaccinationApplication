using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    [Serializable]
    public class Person
    {
        private string FirstName { get; }
        private string LastName { get; }
        public string National_ID { get; set; }
        public string PhoneNumber { get; set; }

        private bool isMale { get; }
        private bool isMarried { get; }
        private bool isEmployed { get; }

        public int isVaccinated { get; set; }    //0 for No, 1 for Once, 2 for ... (better than using bool)
        public string Vaccines { get; set; }
        //public string[] Vaccines { get; set; }    //We use these when different Vaccines foe one person are allowed

        private int BirthYear { get; }
        private int BirthMonth { get; }
        private int BirthDay { get; }

        public Address HomeAddress { get; set; }

        public int AGE
        {
            get
            {
                return (int)(DateTime.Now - new DateTime(BirthYear, BirthMonth, BirthDay)).TotalDays / 365;
            }
        }

        public string GetFirstName()
        {
            return FirstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
        
        public bool GetSex()
        {
            return isMale;
        }

        public Person() { }

        public Person(string _id)
        {
            National_ID = _id;
        }

        public Person(string _firstName, string _lastName, string _id, string _phoneNumber, bool _isMale, bool _isMarried, bool _isEmployed, int _birthYear, int _birthMonth, int _birthDay, string _province, string _city, string _restOfAddress, string _postalCode)
        {
            FirstName = _firstName;
            LastName = _lastName;
            National_ID = _id;
            PhoneNumber = _phoneNumber;
            isMale = _isMale;
            isMarried = _isMarried;
            isEmployed = _isEmployed;
            isVaccinated = 0;
            Vaccines = "";
            BirthYear = _birthYear;
            BirthMonth = _birthMonth;
            BirthDay = _birthDay;
            HomeAddress = new Address(_province, _city, _restOfAddress, _postalCode);
        }

        public Person(string _firstName, string _lastName, string _id, string _phoneNumber, bool _isMale, bool _isMarried, bool _isEmployed, int _isVaccinated, string _vaccines, int _birthYear, int _birthMonth, int _birthDay, string _province, string _city, string _restOfAddress, string _postalCode)
        {
            FirstName = _firstName;
            LastName = _lastName;
            National_ID = _id;
            PhoneNumber = _phoneNumber;
            isMale = _isMale;
            isMarried = _isMarried;
            isEmployed = _isEmployed;
            isVaccinated = _isVaccinated;
            Vaccines = _vaccines;
            BirthYear = _birthYear;
            BirthMonth = _birthMonth;
            BirthDay = _birthDay;
            HomeAddress = new Address(_province, _city,  _restOfAddress, _postalCode);
        }
        
        public static string PersonToString(Person _person)
        {
            return _person.FirstName + ","
                + _person.LastName + ","
                + _person.National_ID + ","
                + _person.PhoneNumber + ","
                + _person.isMale + ","
                + _person.isMarried + ","
                + _person.isEmployed + ","
                + _person.isVaccinated + ","
                + _person.Vaccines + ","
                + _person.BirthYear + ","
                + _person.BirthMonth + ","
                + _person.BirthDay + ","
                + Address.AddressToString(_person.HomeAddress);
        }

        public static Person StringToPerson(string _stringedPerson)
        {
            string[] ListedInput = _stringedPerson.Split(',');

            string _firstName = Convert.ToString(ListedInput[0]);
            string _lastName = Convert.ToString(ListedInput[1]);
            string _nationalID = Convert.ToString(ListedInput[2]);
            string _phoneNumber = Convert.ToString(ListedInput[3]);
            bool _isMale = Convert.ToBoolean(ListedInput[4]);
            bool _isMarried = Convert.ToBoolean(ListedInput[5]);
            bool _isEmployed = Convert.ToBoolean(ListedInput[6]);
            int _isVaccinated = Convert.ToInt16(ListedInput[7]);
            string _vaccines = Convert.ToString(ListedInput[8]);
            int _birthYear = Convert.ToInt16(ListedInput[9]);
            int _birthMonth = Convert.ToInt16(ListedInput[10]);
            int _birthDay = Convert.ToInt16(ListedInput[11]);
            string _province = Convert.ToString(ListedInput[12]);
            string _city = Convert.ToString(ListedInput[13]);
            string _restOfAddress = Convert.ToString(ListedInput[14]);
            string _postalCode = Convert.ToString(ListedInput[15]);
            double _x = Convert.ToDouble(ListedInput[16]);
            double _y = Convert.ToDouble(ListedInput[17]);

            Person person = new Person
                (_firstName,
                _lastName,
                _nationalID,
                _phoneNumber,
                _isMale,
                _isMarried,
                _isEmployed,
                _isVaccinated,
                _vaccines,
                _birthYear,
                _birthMonth,
                _birthDay,
                _province,
                _city,
                _restOfAddress,
                _postalCode);

            person.HomeAddress.ExactLocation.X = _x;
            person.HomeAddress.ExactLocation.Y = _y;

            return person;
        }
    }
}
