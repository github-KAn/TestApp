using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamKhanhAnExamples
{
    
    //Bài toàn đặt chỗ 
    public class Reservation
    {
        public User? MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            //2test case?
            return user.IsAdmin || MadeBy == user;
        }

    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
