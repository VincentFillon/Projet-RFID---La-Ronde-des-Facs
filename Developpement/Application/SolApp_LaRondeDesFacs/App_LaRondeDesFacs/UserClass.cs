using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_LaRondeDesFacs
{
    public class UserClass
    {
        #region GetUser
        public static User getUserID(string id)
        {
            User user = new User();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntity = from u in facSecondaireEntity.User
                             where u.user_id == id
                             select u;
            user = userEntity.FirstOrDefault();
            return user;
        }
        public static string getLastIdUser()
        {
            User user = new User();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntity = from u in facSecondaireEntity.User
                             select u;
            user = userEntity.OrderByDescending(u => u.user_id).FirstOrDefault();
            return user.user_id;
        }

        public static Boolean getExistUser(string id)
        {
            User user = new User();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntity = from u in facSecondaireEntity.User
                             where u.user_id == id
                             select u;
            user = userEntity.FirstOrDefault();
            if (user != null) return true;
            else return false;
        }

        public static List<User> getAllListUsers()
        {
            List<User> listUser = new List<User>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntities = from u in facSecondaireEntity.User
                                select u;
            listUser = userEntities.OrderBy(u => u.nom).ToList();
            return listUser;
        }

        public static List<User> searchUserID(string id)
        {
            List<User> users = new List<User>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntity = from u in facSecondaireEntity.User
                             where u.user_id.Contains(id)
                             select u;
            users = userEntity.ToList();
            return users;
        }
        public static List<User> searchUserNom(string nom)
        {
            List<User> users = new List<User>();
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            var userEntity = from u in facSecondaireEntity.User
                             where u.nom.Contains(nom)
                             select u;
            users = userEntity.ToList();
            return users;
        }
        #endregion

        #region SetUser
        public static void setUser(User user)
        {
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            facSecondaireEntity.User.Add(user);

            facSecondaireEntity.SaveChanges();
        }
        #endregion

        #region DeleteUser
        public static void DeleteUser(User user)
        {
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            facSecondaireEntity.User.Remove(user);
            facSecondaireEntity.SaveChanges();
        }
        public static void DeleteUserbyId(string id)
        {
            User user = getUserID(id);
            FacSecondaireEntities facSecondaireEntity = new FacSecondaireEntities();
            facSecondaireEntity.User.Remove(user);
            facSecondaireEntity.SaveChanges();
        }
        #endregion
    }
}
