using AssetControl.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetControl.Data;
using System.Dynamic;

namespace AssetControl.Logic
{
    internal class UserService : IDisposable
    {
        private User _user;
        private string errorMessage;
        DataSet dsresult;
        public UserService()
        {
            dsresult = new DataSet();
            _user = User.Instance;
        }

        public void Dispose()
        {
            dsresult = null;
            _user = null;
            errorMessage = null;
        }
        public AuthenticationResult UserValidation()
        {
            string encryptedPassword = Encryptor.EncryptWord(_user.Password);
            //get properties from database
            using(DataBaseManager dbm = new DataBaseManager())
            {
                dsresult = dbm.GetUserData();
                errorMessage = dbm.errorMessage;
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return new AuthenticationResult { Success = false, Error = errorMessage };
            }

            if (dsresult.Tables["User"].Rows.Count == 0)
            {
                return new AuthenticationResult()
                {
                    Success = false,
                    Error = "El usuario indicado no existe o se encuentra inactivo",
                    UserProperty = "User"
                };
            }

            DataRow row = dsresult.Tables["User"].Rows[0];
            
                
            if (encryptedPassword == row["password"].ToString())
            {
                _user.UserName = row["username"].ToString();
                _user.Role = Convert.ToUInt16(row["user_role"].ToString());
                _user.RoleDescription = row["role_description"].ToString();
                return new AuthenticationResult { Success = true };
            }
                
            else
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Error = "La constraseña es incorrecta",
                    UserProperty = "Password"
                };
            }
        }//end UserValidation

        public AuthenticationResult UserPasswordChange(string actualPassword, string newPassword, string newConfirmPassword)
        {
            if (actualPassword != User.Instance.Password)
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Error = "La contraseña actual no coincide con la registrada",
                    UserProperty = "Password"
                };
            }
            if (string.IsNullOrEmpty(newPassword.Trim()))
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Error = "La nueva contraseña no puede quedar vacía",
                    UserProperty = "NewPassword"
                };
            }
            if(string.IsNullOrEmpty(newConfirmPassword.Trim()))
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Error = "La confirmación de la nueva contraseña no puede quedar vacía",
                    UserProperty = "ConfirmNewPassword"
                };
            }
            if (newPassword != newConfirmPassword)
            {
                return new AuthenticationResult
                {
                    Success = false,
                    Error = "La nueva contraseña y su confirmación no coinciden",
                    UserProperty = "NewPassword"
                };
            }
            string encryptedPassword = Encryptor.EncryptWord(newPassword);
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.UserPasswordChange(encryptedPassword);
                errorMessage = dbm.errorMessage;
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                return new AuthenticationResult { Success = false, Error = errorMessage };
            }
            User.Instance.Password = newPassword;
            return new AuthenticationResult { Success = true };
        }

        public UserExistsResult UserExists(string newUser)
        {
            DataSet dsCount = new DataSet();
            
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsCount = dbm.UserExists(newUser);                
            }
            if (Convert.ToInt16(dsCount.Tables[0].Rows[0]["count"]) > 0)
            {
                return new UserExistsResult
                {
                    Exists = true,
                    Name = dsCount.Tables[0].Rows[0]["username"].ToString(),
                };
            }
            else
            {
                return new UserExistsResult()
                {
                    Exists = false
                };
            }            
        }

        public List<UserRole> GetUserRoleList()
        {
            List<UserRole> userRoleList = new List<UserRole>();
            
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsresult = dbm.GetUserRolesList();
            }
            //this table is not empty, so it is safe to assume that the dataset will have at least one element
            List<object> userRoles = Utilities.ConvertDataSetToList(dsresult, typeof(UserRole));
            userRoleList = userRoles.Cast<UserRole>().ToList();

            return userRoleList;
        }

        public QueryResult<User> GetUserList(string description, int role, bool active)
        {
            QueryResult<User> result = new QueryResult<User>();
            List<User> userList = new List<User>();
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsresult = dbm.GetUserList(description, role, active);
                result.ErrorMessage = dbm.errorMessage;
            }
            if (string.IsNullOrEmpty(result.ErrorMessage) && dsresult.Tables["Users"].Rows.Count > 0)
            {
                List<object> uList = Utilities.ConvertDataSetToList(dsresult, typeof(User));
                userList = uList.Cast<User>().ToList();
                result.Data = userList;
            }
            return result;
        }

        public string SaveUser(User user, EditType editType)
        {
            string result = string.Empty;
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dbm.SaveUser(user, editType);
                result = dbm.errorMessage;
            }
            return result;
        }

        public string RequirementsValidation(List<string> tablenames)
        {
            Dictionary<string, string> aliasNames = new Dictionary<string, string>()
            {
                { "asset_locations", "Ubicaciones" },
                { "asset_types", "Tipos de activo" },
                { "branches", "Filiales" }
            };
            using (DataBaseManager dbm = new DataBaseManager())
            {
                dsresult = dbm.RequirementsValidation(tablenames);
            }
            List<string> emptyTables = new List<string>();
            foreach (DataRow row in dsresult.Tables["Results"].Rows)
            {
                if (Convert.ToInt32(row["Count"].ToString()) == 0)
                {
                    string originalName = row["TableName"].ToString();
                    string alias = aliasNames.ContainsKey(originalName) ? aliasNames[originalName] : originalName;
                    emptyTables.Add(alias);
                }
            }

            if (emptyTables.Count > 0)
            {
                string message = "Primero debe ingresar datos de:\n" +
                    string.Join(", ", emptyTables) + 
                    "\nantes de crear los activos";
                return message;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
