using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    [Serializable]
    public class Address
    {
        public string Province { get; set; }
        public string City { get; set; }
        public string RestOfAddress { get; set; }
        public string PostalCode { get; set; }
        public Coordinate ExactLocation { get; }
        
        public Address(string _province, string _city, string _restOfAddress, string _postalCode)
        {
            Province = _province;
            City = _city;
            RestOfAddress = _restOfAddress;
            PostalCode = _postalCode;
            ExactLocation = new Coordinate(_postalCode);
        }

        public static string AddressToString(Address _address)
        {
            return _address.Province + ","
                + _address.City + ","
                + _address.RestOfAddress + ","
                + _address.PostalCode + ","
                + Coordinate.CoordinateToString(_address.ExactLocation);
        }
    }
}
