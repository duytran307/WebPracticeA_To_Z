using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWebAPI.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string UserID ,string Password )
        {
            this.UserID = UserID;
            this.Password = Password;


        }

        //public List<User> GetUserList() {
        //    List<User> lsUser = new List<User>();

        //    lsUser.Add(new User("a", "pwda", "Fa","La",true));
        //    lsUser.Add(new User("a1", "pwda1", "Fa1", "La1", true));
        //    lsUser.Add(new User("a2", "pwda2", "Fa2", "La2", true));
        //    lsUser.Add(new User("a3", "pwda3", "Fa3", "La3", true));
        //    lsUser.Add(new User("a4", "pwda4", "Fa4", "La4", true));
        //    lsUser.Add(new User("a5", "pwda5", "Fa5", "La5", false));
        //    return lsUser;
        //}


        //public bool Login(string UserID, string Password)
        //{

        //    User user = new User("a", "pwda", "Fa", "La", true);


        //    //lsUser.Add(new User("a1", "pwda1", "Fa1", "La1", true));
        //    //lsUser.Add(new User("a2", "pwda2", "Fa2", "La2", true));
        //    //lsUser.Add(new User("a3", "pwda3", "Fa3", "La3", true));
        //    //lsUser.Add(new User("a4", "pwda4", "Fa4", "La4", true));
        //    //lsUser.Add(new User("a5", "pwda5", "Fa5", "La5", false));
        //    if (user.UserID != UserID || user.Password != Password || user.IsActive == false)
        //        return false;
       
        //    return true;
        //}


    }
}
