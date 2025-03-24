using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamKhanhAnExamples
{
    //Bài toán định dạng số điện thoại 
    public class PhoneNumber
    {
        public string Area { get; }
        public string Major { get; }
        public string Minor { get; }

        private PhoneNumber(string area, string major, string minor)
        {
            Area = area;
            Major = major;
            Minor = minor;
        }

        public static PhoneNumber Parse(string number)
        {
            //đầu vào một test case
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Phone number cannot be blank.");
            //1 test case
            if (number.Length != 10)
                throw new ArgumentException("Phone number should be 10 digits long.");
            //1 test case
            var area = number.Substring(0, 3);
            var major = number.Substring(3, 3);
            var minor = number.Substring(6);
            return new PhoneNumber(area, major, minor);
        }

        public override string ToString()
        {
            return string.Format($"({Area}){Major}-{Minor}");
            //trả ra định dạng 1 test case
        }
    }
}
