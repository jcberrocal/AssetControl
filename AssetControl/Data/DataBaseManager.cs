using AssetControl.Classes;
using AssetControl.Logic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetControl.Data
{
    internal class DataBaseManager : IDisposable
    {
        public string errorMessage;
        private string _connectionString;
        private DataSet dsResult = new DataSet();
        private User _user;
        private AppConfiguration _appConfiguration;
        private StringBuilder _sql;

        public DataBaseManager()
        {
            _appConfiguration = AppConfiguration.Instance;
            _user = User.Instance;
            _connectionString = $"Host={_appConfiguration.Server};Username={_appConfiguration.User};" +
                $"Password={_appConfiguration.Password};Database={_appConfiguration.DataBase};" +
                $"Port={_appConfiguration.Port};ApplicationName=Activos";
            _sql = new StringBuilder();
        }

        public void Dispose()
        {
            dsResult = null;
            _connectionString = null;
            _appConfiguration = null;
            _user = null;
            _sql = null;
        }

        private void ExecuteNonQuery(string sql, NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection, transaction))
                        {
                            command.Parameters.AddRange(parameters);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (NpgsqlException e)
                    {
                        errorMessage = e.Message;
                        transaction.Rollback();
                    }
                }
            }
        }

        private void ExecuteNonQuery(string sql)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (NpgsqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (NpgsqlException e)
                    {
                        errorMessage = e.Message;
                        transaction.Rollback();
                    }
                }
            }
        }

        private int ExecuteScalar(string sql)
        {
            int result = 0;
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        result = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                catch (NpgsqlException e)
                {
                    errorMessage = e.Message;
                }

            }
            return result;
        }

        private DataSet GetDataSet(string sql, NpgsqlParameter[] parameters, string table = "Table")
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddRange(parameters);
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dsResult, table);
                        }
                    }
                }
                catch (NpgsqlException e)
                {
                    if (e.InnerException is SocketException)
                    {
                        errorMessage = "No es posible conectarse al sevidor." +
                            "\nVerifique el estado de la base de datos y las credenciales de conexión";
                    }
                    else if (e.ErrorCode == -2147467259)
                    {
                        errorMessage = "Error de autenticación en la base de datos." +
                            "\nVerifique las credenciales de conexión";
                    }
                    else
                        errorMessage = e.Message;
                }
            }
            return dsResult;
        }

        private DataSet GetDataSet(string sql, string table = "Table")
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dsResult, table);
                        }
                    }
                }
                catch (NpgsqlException e)
                {
                    if (e.InnerException is SocketException)
                    {
                        errorMessage = "No es posible conectarse al sevidor." +
                            "\nVerifique el estado de la base de datos y las credenciales de conexión";
                    }
                    else if (e.ErrorCode == -2147467259)
                    {
                        errorMessage = "Error de autenticación en la base de datos." +
                            "\nVerifique las credenciales de conexión";
                    }
                    else
                        errorMessage = e.Message;
                }
            }
            return dsResult;
        }

        public DataSet GetUserData()
        {
            _sql.AppendLine("SELECT");
            _sql.AppendLine("    user_id,");
            _sql.AppendLine("    username,");
            _sql.AppendLine("    password,");
            _sql.AppendLine("    u.user_role,");
            _sql.AppendLine("    ur.role_description");
            _sql.AppendLine("FROM users u");
            _sql.AppendLine("JOIN user_roles ur USING(user_role)");
            _sql.AppendLine("WHERE u.end_date IS NULL");
            _sql.AppendLine("AND user_id = @user;");

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@user",NpgsqlTypes.NpgsqlDbType.Varchar) {Value = _user.UserId}
            };

            dsResult = GetDataSet(_sql.ToString(), parameters, "User");

            return dsResult;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SocketException)
            {
                return false;
            }
            catch (NpgsqlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void SaveAuditRecord(AuditRecord record)
        {
            DateTime date = DateTime.Now;
            _sql.AppendLine("INSERT INTO audit_logs (log_date, user_id, action, table_name, record_id, old_value, new_value, details)");
            _sql.AppendLine("VALUES (@log_date, @user_id, @action, @table_name, @record_id, @old_value, @new_value, @details);");

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@log_date", NpgsqlTypes.NpgsqlDbType.Date) {Value = date},
                new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = record.UserId},
                new NpgsqlParameter("@action", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = record.Action},
                new NpgsqlParameter("@table_name", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {Value = string.IsNullOrEmpty(record.TableName) ? DBNull.Value : (object)record.TableName},
                new NpgsqlParameter("@record_id", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {Value = string.IsNullOrEmpty(record.RecordId) ? DBNull.Value : (object)record.RecordId},
                new NpgsqlParameter("@old_value", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {Value = string.IsNullOrEmpty(record.OldValue) ? DBNull.Value : (object) record.OldValue},
                new NpgsqlParameter("@new_value", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {Value = string.IsNullOrEmpty(record.NewValue) ? DBNull.Value : (object) record.NewValue},
                new NpgsqlParameter("@details", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {Value = string.IsNullOrEmpty(record.Details) ? DBNull.Value : (object) record.Details}
            };

            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public DataSet UserExists(string newUser)
        {
            _sql.AppendLine("SELECT COALESCE((SELECT username FROM users WHERE TRIM(user_id) = @new_user), '') AS username,");
            _sql.AppendLine("    COUNT(*)");
            _sql.AppendLine("FROM users");
            _sql.AppendLine("WHERE user_id = @new_user;");

            NpgsqlParameter[] parameter = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@new_user", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = newUser.Trim()}
            };

            return dsResult = GetDataSet(_sql.ToString(), parameter);
        }

        public DataSet GetAssetTypesData(string description, bool active)
        {
            _sql.AppendLine("SELECT  asset_type_id AS \"AssetTypeId\",");
            _sql.AppendLine("    type_description AS \"TypeDescription\",");
            _sql.AppendLine("    end_date AS \"EndDate\"");
            _sql.AppendLine("FROM asset_types");
            _sql.AppendLine("WHERE 1 = 1");
            if (!string.IsNullOrEmpty(description))
            {
                _sql.AppendLine("AND type_description ILIKE @description");
            }
            if (active)
            {
                _sql.AppendLine("AND end_date IS NULL");
            }
            _sql.Append(";");

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{description}%"}
            };

            dsResult = GetDataSet(_sql.ToString(), parameters, "AssetTypes");
            return dsResult;
        }

        public void SaveAssetType(AssetType type, EditType editType)
        {
            NpgsqlParameter[] parameters;
            string appUser = User.Instance.UserId;
            switch (editType)
            {
                case EditType.Insert:
                    _sql.AppendLine("INSERT INTO asset_types (type_description, created_at, created_by)");
                    _sql.AppendLine("VALUES (@description, now(), @user_id);");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = type.TypeDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser}
                    };
                    break;
                case EditType.Update:
                    _sql.AppendLine("UPDATE asset_types");
                    _sql.AppendLine("SET type_description = @description, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_type_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value=type.TypeDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = type.AssetTypeId}
                    };
                    break;
                case EditType.Endate:
                    _sql.AppendLine("UPDATE asset_types");
                    _sql.AppendLine("    SET end_date = now(), modified_at = now(), modified_by = @user_id, endated_by = @user_id");
                    _sql.AppendLine("WHERE asset_type_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = type.AssetTypeId}
                    };
                    break;
                case EditType.Reactivate:
                    _sql.AppendLine("UPDATE asset_types");
                    _sql.AppendLine("    SET end_date = NULL, endated_by = NULL, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_type_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id",NpgsqlTypes.NpgsqlDbType.Varchar) {Value = User.Instance.UserId},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = type.AssetTypeId}
                    };
                    break;
                default:
                    parameters = new NpgsqlParameter[0];
                    break;
            }
            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public DataSet GetUserRolesList()
        {
            _sql.AppendLine("SELECT user_role AS \"RoleId\",");
            _sql.AppendLine("   role_description AS \"RoleDescription\"");
            _sql.AppendLine("FROM user_roles");
            _sql.Append("ORDER BY 1;");

            dsResult = GetDataSet(_sql.ToString(), "UserRoles");
            return dsResult;
        }

        internal DataSet GetUserList(string description, int role, bool active)
        {
            _sql.AppendLine("SELECT user_id AS \"UserId\",");
            _sql.AppendLine("   username AS \"UserName\",");
            _sql.AppendLine("   user_role AS \"Role\",");
            _sql.AppendLine("   role_description AS \"RoleDescription\",");
            _sql.AppendLine("   password AS \"Password\",");
            _sql.AppendLine("   u.end_date AS \"EndDate\"");
            _sql.AppendLine("FROM users u");
            _sql.AppendLine("JOIN user_roles ur using(user_role)");
            _sql.AppendLine("WHERE 1 = 1");
            if (active)
                _sql.AppendLine("AND u.end_date IS NULL");
            if (!string.IsNullOrEmpty(description))
                _sql.AppendLine("AND username ILIKE @description");
            if (role > 0)
                _sql.AppendLine("AND user_role = @user_role");
            _sql.Append(";");

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{description}%"},
                new NpgsqlParameter("@user_role", NpgsqlTypes.NpgsqlDbType.Integer) {Value = role}
            };
            dsResult = GetDataSet(_sql.ToString(), parameters, "Users");
            return dsResult;
        }

        public void SaveUser(User user, EditType editType)
        {
            NpgsqlParameter[] parameters;
            string appUser = User.Instance.UserId;
            switch (editType)
            {
                case EditType.Insert:
                    _sql.AppendLine("INSERT INTO users (user_id, username, password, user_role, created_at, created_by)");
                    _sql.AppendLine("VALUES (@user_id, @username, @password, @role, now(), @created_by);");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserId},
                        new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserName},
                        new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.Password},
                        new NpgsqlParameter("@role", NpgsqlTypes.NpgsqlDbType.Integer) {Value = user.Role},
                        new NpgsqlParameter("@created_by", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser}
                    };
                    break;
                case EditType.Update:
                    _sql.AppendLine("UPDATE users");
                    _sql.AppendLine("    SET username = @username, password = @password, user_role = @role, modified_at = now(), modified_by = @modified_by");
                    _sql.AppendLine("WHERE user_id = @user_id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserName},
                        new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.Password},
                        new NpgsqlParameter("@role", NpgsqlTypes.NpgsqlDbType.Integer) {Value = user.Role},
                        new NpgsqlParameter("@modified_by", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserId}
                    };
                    break;
                case EditType.Endate:
                    _sql.AppendLine("UPDATE users");
                    _sql.AppendLine("    SET end_date = now(), modified_at = now(), modified_by = @app_user, endated_by = @app_user");
                    _sql.AppendLine("WHERE user_id = @user_id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@app_user", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserId}
                    };
                    break;
                case EditType.Reactivate:
                    _sql.AppendLine("UPDATE users");
                    _sql.AppendLine("    SET end_date = NULL, endated_by = NULL, modified_at = now(), modified_by = @app_user");
                    _sql.AppendLine("WHERE user_id = @user_id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@app_user", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = user.UserId}
                    };
                    break;
                default:
                    parameters = new NpgsqlParameter[0];
                    break;
            }
            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public void UserPasswordChange(string password)
        {
            _sql.AppendLine("UPDATE users");
            _sql.AppendLine("    SET password = @password, modified_at = now(), modified_by = @user_id");
            _sql.AppendLine("WHERE user_id = @user_id;");
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = password},
                new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = _user.UserId}
            };
            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public DataSet RequirementsValidation(List<string> tableNames)
        {
            DataTable dt = new DataTable("Results");
            dt.Columns.Add("TableName", typeof(string));
            dt.Columns.Add("Count", typeof(int));
            dsResult.Tables.Add(dt);

            foreach (string table in tableNames)
            {
                _sql.AppendLine($"SELECT COUNT(*)");
                _sql.AppendLine($"FROM {table}");
                _sql.AppendLine($"WHERE end_date IS NULL;");
                int count = ExecuteScalar(_sql.ToString());
                dt.Rows.Add(table, count);
                _sql.Clear();
            }
            return dsResult;
        }

        public DataSet GetBranchesData(string description, bool active)
        {
            _sql.AppendLine("SELECT branch_id AS \"BranchId\",");
            _sql.AppendLine("    branch_description AS \"BranchDescription\",");
            _sql.AppendLine("    end_date AS \"EndDate\"");
            _sql.AppendLine("FROM branches");
            _sql.AppendLine("WHERE 1 = 1");
            if (!string.IsNullOrEmpty(description))
            {
                _sql.AppendLine("AND branch_description ILIKE @description");
            }
            if (active)
            {
                _sql.AppendLine("AND end_date IS NULL");
            }
            _sql.Append(";");
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{description}%"}
            };
            dsResult = GetDataSet(_sql.ToString(), parameters, "Branches");
            return dsResult;
        }

        public void SaveBranch(Branch branch, EditType editType)
        {
            NpgsqlParameter[] parameters;
            string appUser = User.Instance.UserId;
            switch (editType)
            {
                case EditType.Insert:
                    _sql.AppendLine("INSERT INTO branches (branch_description, created_at, created_by)");
                    _sql.AppendLine("VALUES (@description, now(), @user_id);");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = branch.BranchDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser}
                    };
                    break;
                case EditType.Update:
                    _sql.AppendLine("UPDATE branches");
                    _sql.AppendLine("    SET branch_description = @description, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE branch_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = branch.BranchDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = branch.BranchId}
                    };
                    break;
                case EditType.Endate:
                    _sql.AppendLine("UPDATE branches");
                    _sql.AppendLine("    SET end_date = now(), modified_at = now(), modified_by = @user_id, endated_by = @user_id");
                    _sql.AppendLine("WHERE branch_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = branch.BranchId}
                    };
                    break;
                case EditType.Reactivate:
                    _sql.AppendLine("UPDATE branches");
                    _sql.AppendLine("    SET end_date = NULL, endated_by = NULL, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE branch_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = User.Instance.UserId},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = branch.BranchId}
                    };
                    break;
                default:
                    parameters = new NpgsqlParameter[0];
                    break;
            }
            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public DataSet GetLocationsData(string description, bool active)
        {
            _sql.AppendLine("SELECT asset_location_id AS \"AssetLocationId\",");
            _sql.AppendLine("    location_description AS \"LocationDescription\",");
            _sql.AppendLine("    end_date AS \"EndDate\"");
            _sql.AppendLine("FROM asset_locations");
            _sql.AppendLine("WHERE 1 = 1");
            if (!string.IsNullOrEmpty(description))
            {
                _sql.AppendLine("AND location_description ILIKE @description");
            }
            if (active)
            {
                _sql.AppendLine("AND end_date IS NULL");
            }
            _sql.Append(";");
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{description}%"}
            };
            dsResult = GetDataSet(_sql.ToString(), parameters, "Locations");
            return dsResult;
        }

        public void SaveLocation(AssetLocation location, EditType editType)
        {
            NpgsqlParameter[] parameters;
            string appUser = User.Instance.UserId;
            switch (editType)
            {
                case EditType.Insert:
                    _sql.AppendLine("INSERT INTO asset_locations (location_description, created_at, created_by)");
                    _sql.AppendLine("VALUES (@description, now(), @user_id);");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = location.LocationDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser}
                    };
                    break;
                case EditType.Update:
                    _sql.AppendLine("UPDATE asset_locations");
                    _sql.AppendLine("    SET location_description = @description, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_location_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = location.LocationDescription},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = location.AssetLocationId}
                    };
                    break;
                case EditType.Endate:
                    _sql.AppendLine("UPDATE asset_locations");
                    _sql.AppendLine("    SET end_date = now(), modified_at = now(), modified_by = @user_id, endated_by = @user_id");
                    _sql.AppendLine("WHERE asset_location_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = location.AssetLocationId}
                    };
                    break;
                case EditType.Reactivate:
                    _sql.AppendLine("UPDATE asset_locations");
                    _sql.AppendLine("    SET end_date = NULL, endated_by = NULL, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_location_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = User.Instance.UserId},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = location.AssetLocationId}
                    };
                    break;
                default:
                    parameters = new NpgsqlParameter[0];
                    break;
            }

            ExecuteNonQuery(_sql.ToString(), parameters);
        }

        public DataSet GetAssetTypesList()
        {
            _sql.AppendLine("SELECT asset_type_id AS \"AssetTypeId\",");
            _sql.AppendLine("   type_description AS \"TypeDescription\",");
            _sql.AppendLine("   end_date AS \"EndDate\"");
            _sql.AppendLine("FROM asset_types");
            _sql.AppendLine("WHERE end_date IS NULL");
            _sql.AppendLine("ORDER BY 1;");
            dsResult = GetDataSet(_sql.ToString(), "AssetTypes");
            return dsResult;
        }

        public DataSet GetAssetStatusesList()
        {
            _sql.AppendLine("SELECT status AS \"Status\",");
            _sql.AppendLine("    status_description AS \"StatusDescription\"");
            _sql.AppendLine("FROM asset_status");
            _sql.AppendLine("ORDER BY 1;");
            dsResult = GetDataSet(_sql.ToString(), "AssetStatus");
            return dsResult;
        }

        public DataSet GetAssetLocationsList()
        {
            _sql.AppendLine("SELECT asset_location_id AS \"AssetLocationId\",");
            _sql.AppendLine("    location_description AS \"LocationDescription\",");
            _sql.AppendLine("    end_date AS \"EndDate\"");
            _sql.AppendLine("FROM asset_locations");
            _sql.AppendLine("WHERE end_date IS NULL");
            _sql.AppendLine("ORDER BY 1;");
            dsResult = GetDataSet(_sql.ToString(), "AssetLocations");
            return dsResult;
        }

        public DataSet GetBranchesList()
        {
            _sql.AppendLine("SELECT branch_id AS \"BranchId\",");
            _sql.AppendLine("    branch_description AS \"BranchDescription\",");
            _sql.AppendLine("    end_date AS \"EndDate\"");
            _sql.AppendLine("FROM branches");
            _sql.AppendLine("WHERE end_date IS NULL");
            _sql.AppendLine("ORDER BY 1;");
            dsResult = GetDataSet(_sql.ToString(), "Branches");
            return dsResult;
        }

        public DataSet GetRetirementReasons()
        {
            _sql.AppendLine("SELECT retirement_reason AS \"RetirementReasonId\",");
            _sql.AppendLine("    reason_description AS \"ReasonDescription\"");
            _sql.AppendLine("FROM asset_retirement_reasons;");
            dsResult = GetDataSet(_sql.ToString(), "RetirementReasons");
            return dsResult;
        }

        public DataSet GetAssetsData(AssetSearchOptions options)
        {
            _sql.AppendLine("SELECT asset_id AS \"Id\",");
            _sql.AppendLine("   asset_description AS \"Description\",");
            _sql.AppendLine("   asset_type AS \"AssetType\",");
            _sql.AppendLine("   type_description AS \"AssetTypeDescription\",");
            _sql.AppendLine("   status AS \"Status\",");
            _sql.AppendLine("   status_description AS \"StatusDescription\",");
            _sql.AppendLine("   asset_location AS \"Location\",");
            _sql.AppendLine("   location_description AS \"LocationDescription\",");
            _sql.AppendLine("   branch AS \"Branch\",");
            _sql.AppendLine("   branch_description AS \"BranchDescription\",");
            _sql.AppendLine("   price AS \"Price\",");
            _sql.AppendLine("   observations AS \"Observations\",");
            _sql.AppendLine("   serial_number AS \"SerialNumber\",");
            _sql.AppendLine("   asset_tag AS \"AssetTag\",");
            _sql.AppendLine("   generic_asset AS \"GenericAsset\",");
            _sql.AppendLine("   quantity AS \"Quantity\",");
            _sql.AppendLine("   purchase_date AS \"PurchaseDate\",");
            _sql.AppendLine("   warranty_months AS \"WarrantyMonths\",");
            _sql.AppendLine("   retirement_reason AS \"RetirementReason\",");
            _sql.AppendLine("   reason_description AS \"RetirementReasonDescription\",");
            _sql.AppendLine("   a.end_date AS \"EndDate\",");
            _sql.AppendLine("   endate_note AS \"EndateNote\"");
            _sql.AppendLine("FROM assets a");
            _sql.AppendLine("JOIN asset_types at ON a.asset_type = at.asset_type_id");
            _sql.AppendLine("JOIN asset_status USING (status)");
            _sql.AppendLine("JOIN asset_locations al ON asset_location = asset_location_id");
            _sql.AppendLine("JOIN branches b ON branch = branch_id");
            _sql.AppendLine("LEFT JOIN asset_retirement_reasons arr USING (retirement_reason)");
            _sql.AppendLine("WHERE 1 = 1");
            // validate options and build the query
            if(!string.IsNullOrEmpty(options.Description))
            {
                _sql.AppendLine("AND asset_description ILIKE @description");
            }
            if (options.AssetType > 0)
            {
                _sql.AppendLine("AND asset_type = @asset_type");
            }
            if (options.Status > 0)
            {
                _sql.AppendLine("AND status = @status");
            }
            if (options.Location > 0)
            {
                _sql.AppendLine("AND asset_location = @location");
            }
            if (options.Branch > 0)
            {
                _sql.AppendLine("AND branch = @branch");
            }
            if(options.GenericAsset)
            {
                _sql.AppendLine("AND generic_asset = FALSE");
            }
            if (options.ActiveOnly)
            {
                _sql.AppendLine("AND a.end_date IS NULL");
            }
            if (!string.IsNullOrEmpty(options.AssetTag))
            {
                _sql.AppendLine("AND asset_tag ILIKE @asset_tag");
            }
            _sql.Append(";");
            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{options.Description}%"},
                new NpgsqlParameter("@asset_type", NpgsqlTypes.NpgsqlDbType.Integer) {Value = options.AssetType},
                new NpgsqlParameter("@status", NpgsqlTypes.NpgsqlDbType.Integer) {Value = options.Status},
                new NpgsqlParameter("@location", NpgsqlTypes.NpgsqlDbType.Integer) {Value = options.Location},
                new NpgsqlParameter("@branch", NpgsqlTypes.NpgsqlDbType.Integer) {Value = options.Branch},
                new NpgsqlParameter("@asset_tag", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = $"%{options.AssetTag}%"}
            };
            dsResult = GetDataSet(_sql.ToString(), parameters, "Assets");
            return dsResult;
        }

        public void SaveAsset(Asset asset, EditType editType)
        {
            NpgsqlParameter[] parameters;
            string appUser = User.Instance.UserId;
            switch (editType)
            {
                case EditType.Insert:
                    _sql.AppendLine("INSERT INTO assets (asset_description, asset_type, status, asset_location, branch, price, observations, serial_number, asset_tag, generic_asset, quantity, purchase_date, warranty_months, created_at, created_by)");
                    _sql.AppendLine("VALUES (@description, @asset_type, @status, @location, @branch, @price, @observations, @serial_number, @asset_tag, @generic_asset, @quantity, @purchase_date::date, @warranty_months, now(), @user_id);");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = asset.Description},
                        new NpgsqlParameter("@asset_type", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.AssetType},
                        new NpgsqlParameter("@status", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Status},
                        new NpgsqlParameter("@location", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Location},
                        new NpgsqlParameter("@branch", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Branch},
                        new NpgsqlParameter("@price", NpgsqlTypes.NpgsqlDbType.Numeric) {Value = asset.Price},
                        new NpgsqlParameter("@observations", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = asset.Observations},
                        new NpgsqlParameter("@serial_number", NpgsqlTypes.NpgsqlDbType.Varchar) 
                            {Value = asset.SerialNumber == null? DBNull.Value : (object)asset.SerialNumber},
                        new NpgsqlParameter("@asset_tag", NpgsqlTypes.NpgsqlDbType.Varchar)
                            {Value = asset.AssetTag == null? DBNull.Value : (object)asset.AssetTag},
                        new NpgsqlParameter("@generic_asset", NpgsqlTypes.NpgsqlDbType.Boolean) {Value = asset.GenericAsset},
                        new NpgsqlParameter("@quantity", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Quantity},
                        new NpgsqlParameter("@purchase_date", NpgsqlTypes.NpgsqlDbType.Date)
                            {Value = asset.PurchaseDate.HasValue ? (object)asset.PurchaseDate : DBNull.Value},
                        new NpgsqlParameter("@warranty_months", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.WarrantyMonths},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser }
                     };
                    break;
                case EditType.Update:
                    _sql.AppendLine("UPDATE assets");
                    _sql.AppendLine("   SET asset_description = @description,");
                    _sql.AppendLine("   asset_location = @location,");
                    _sql.AppendLine("   branch = @branch,");
                    _sql.AppendLine("   price = @price,");
                    _sql.AppendLine("   observations = @observations,");
                    _sql.AppendLine("   serial_number = @serial_number,");
                    _sql.AppendLine("   asset_tag = @asset_tag,");
                    _sql.AppendLine("   generic_asset = @generic_asset,");
                    _sql.AppendLine("   quantity = @quantity,");
                    _sql.AppendLine("   purchase_date = @purchase_date::date,");
                    _sql.AppendLine("   warranty_months = @warranty_months,");
                    _sql.AppendLine("   modified_at = now(),");
                    _sql.AppendLine("   modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_id = @id;");

                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@description", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = asset.Description},
                        new NpgsqlParameter("@location", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Location},
                        new NpgsqlParameter("@branch", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Branch},
                        new NpgsqlParameter("@price", NpgsqlTypes.NpgsqlDbType.Numeric) {Value = asset.Price},
                        new NpgsqlParameter("@observations", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = asset.Observations},
                        new NpgsqlParameter("@serial_number", NpgsqlTypes.NpgsqlDbType.Varchar)
                            {Value = asset.SerialNumber == null? DBNull.Value : (object)asset.SerialNumber},
                        new NpgsqlParameter("@asset_tag", NpgsqlTypes.NpgsqlDbType.Varchar)
                            {Value = asset.AssetTag == null? DBNull.Value : (object)asset.AssetTag},
                        new NpgsqlParameter("@generic_asset", NpgsqlTypes.NpgsqlDbType.Boolean) {Value = asset.GenericAsset},
                        new NpgsqlParameter("@quantity", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Quantity},
                        new NpgsqlParameter("@purchase_date", NpgsqlTypes.NpgsqlDbType.Date)
                            {Value = asset.PurchaseDate.HasValue ? (object)asset.PurchaseDate : DBNull.Value},
                        new NpgsqlParameter("@warranty_months", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.WarrantyMonths},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Id}
                    };
                    break;
                case EditType.Endate:
                    _sql.AppendLine("UPDATE assets");
                    _sql.AppendLine("    SET retirement_reason = @reason, endate_note = @endate_note, end_date = now(), modified_at = now(), modified_by = @user_id, endated_by = @user_id");
                    _sql.AppendLine("WHERE asset_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@reason", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.RetirementReason},
                        new NpgsqlParameter("@endate_note", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = asset.EndateNote},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Id}
                    };
                    break;
                case EditType.ChangeStatus:
                    _sql.AppendLine("UPDATE assets");
                    _sql.AppendLine("    SET status = @status, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@status", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Status},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Id}
                    };
                    break;
                case EditType.Move:
                    _sql.AppendLine("UPDATE assets");
                    _sql.AppendLine("    SET  branch = @branch, modified_at = now(), modified_by = @user_id");
                    _sql.AppendLine("WHERE asset_id = @id;");
                    parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@branch", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Branch},
                        new NpgsqlParameter("@user_id", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = appUser},
                        new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) {Value = asset.Id}
                    };
                    break;
                default:
                    parameters = new NpgsqlParameter[0];
                    break;
            }
            ExecuteNonQuery(_sql.ToString(), parameters);
        }
    }
}
