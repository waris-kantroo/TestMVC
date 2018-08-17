using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestMVC.Models;

namespace TestMVC
{
    public class EmployeeData
    {
        public List<Employee> GetEmployees() => new List<Employee>()
            {
             new Employee {Id=1,FullName="waris kantroo",DOB = DateTime.Parse("08/03/1988"),address = InitializeAddress()},
             new Employee {Id=2,FullName="Roger Federer",DOB = DateTime.Parse("08/03/1978"),address = InitializeSecondAddress()},
             new Employee {Id=3,FullName="Rafa Nadal",DOB = DateTime.Parse("08/03/1983"),address = InitializeThirdAddress()},
             new Employee {Id=4,FullName="Novak Djokovic",DOB = DateTime.Parse("08/03/1985"),address = InitializeFourthAddress()}
            };

        private static Address InitializeAddress()
        {
            var address = new Address
            {
                telephone = 1111111,
                city = "Banaglore",
                pincode = "192123Tral"
            };
            address.subAddress = new SubAddress();
            address.subAddress.city = "BTM City";
            address.subAddress.pincode = "560076BTM";
            address.subAddress.telephone = 9999999;
            return address;
        }
        private static Address InitializeSecondAddress()
        {
            var address = new Address
            {
                telephone = 22222222,
                city = "Switzerland",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "Swiss City",
                pincode = "560076Swiss",
                telephone = 88888888
            };
            return address;
        }

        private static Address InitializeThirdAddress()
        {
            var address = new Address
            {
                telephone = 444444444,
                city = "England",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "England City",
                pincode = "560076Swiss",
                telephone = 66666666
            };
            return address;
        }

        private static Address InitializeFourthAddress()
        {
            var address = new Address
            {
                telephone = 3333333,
                city = "Serbia",
                pincode = "192123Swiss"
            };
            address.subAddress = new SubAddress
            {
                city = "Serbia City",
                pincode = "560076Swiss",
                telephone = 777777777
            };
            return address;
        }
    }
}