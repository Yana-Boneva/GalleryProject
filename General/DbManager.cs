using GalleryProject.Entity;
using System.Data;
using System.Data.SqlClient;

namespace GalleryProject.General
{
    public static class DbManager
    {
        public static Entity.User? LoadUser(string loginName)
        {
            Dictionary<string, object> parameters = new()
            {
                { "loginName", loginName }
            };
            DataTable resultTable = LoadData(@"
                SELECT TOP 1 
                    Id, Username, Email, AdminRole, Password, CreateDate from [User] 
                WHERE Username = @loginName OR Email = @loginName ", parameters);
            if (resultTable.Rows.Count == 0)
                return null;
            else
            {
                return ConvertToUser(resultTable.Rows[0]);
            }
        }

        private static User ConvertToUser(DataRow row)
        {
            int userID = (int)row["Id"];
            return new User
            {
                ID = userID,
                Username = (string)row["Username"],
                Email = (string)row["Email"],
                IsAdmin = (short)row["AdminRole"] == 1,
                Password = (string)row["Password"],
                CreateDate = (string)row["CreateDate"]
            };
        }

        public static bool IsUserExists(string loginName, int? excludeID = null)
        {
            User? user = LoadUser(loginName);
            return user != null && user.ID != excludeID;
        }

        public static bool IsEmailExists(string email, int? excludeID = null)
        {
            User? user = LoadUser(email);
            return user != null && user.ID != excludeID;
        }

        public static void CreateUser(string userName, string email, string createDate, string password)
        {
            string sqlQuery = @"
                INSERT INTO [User] (createdate, password, username, email) 
                VALUES (@createDate, @password, @username, @email) ";
            Dictionary<string, object> parameters = new()
            {
                { "createDate", createDate },
                { "password", password },
                { "username", userName },
                { "email", email },
            };

            ModifyData(sqlQuery, parameters);
        }

        public static List<Style> LoadStyles()
        {
            List<Style> items = new();
            DataTable resultTable = LoadData("SELECT * FROM Style");

            foreach (DataRow row in resultTable.Rows)
            {
                items.Add(ConvertToStyle(row));
            }
            return items;
        }

        private static Style ConvertToStyle(DataRow row)
        {
            return new Style
            {
                ID = Convert.ToInt32(row["ID"]),
                Name = (string)row["Name"],
                Description = (string)row["Description"],
            };
        }

        public static Image? ConvertToImage(object photoData)
        {
            if (photoData is DBNull)
            {
                // no saved photo
                return null;
            }
            else
            {
                using MemoryStream ms = new((byte[])photoData);
                return Image.FromStream(ms);
            }
        }

        public static Image? LoadUserPhoto(int userID)
        {
            Image? image = null;
            Dictionary<string, object> parameters = new()
            {
                { "userID", userID }
            };

            try
            {
                DataTable data = LoadData(@"
                SELECT Photo
                FROM User 
                WHERE ID = @userID ", parameters);

                if (data.Rows.Count > 0)
                {
                    image = ConvertToImage(data.Rows[0]["photo"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
            }

            return image;
        }

        private static DataTable LoadData(string sqlQuery, Dictionary<string, object>? parameters = null)
        {
            try
            {
                using (SqlConnection con = new(Constants.DBConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new(sqlQuery, con);
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    SqlDataAdapter adapter = new()
                    {
                        SelectCommand = cmd
                    };
                    DataTable resultTable = new();
                    adapter.Fill(resultTable);
                    return resultTable;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
                return new DataTable();
            }
        }

        private static bool ModifyData(string sqlQuery, Dictionary<string, object>? parameters = null)
        {
            try
            {
                using (SqlConnection con = new(Constants.DBConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new(sqlQuery, con);
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
                return false;
            }
        }

        public static bool InsertStyle(Style style)
        {
            string sqlQuery = @"
                INSERT INTO Style (Name, Description) 
                VALUES (@Name, @Description)";
            Dictionary<string, object> parameters = new()
            {
                { "Name", style.Name},
                { "Description", style.Description }
            };

            return ModifyData(sqlQuery, parameters);
        }

        public static bool DeleteStyle(int styleID)
        {
            string sqlQuery = @"DELETE Style WHERE ID = @ID";
            Dictionary<string, object> parameters = new()
            {
                { "ID", styleID}
            };

            return ModifyData(sqlQuery, parameters);
        }

        public static bool UpdateStyle(Style style)
        {
            string sqlQuery = @"
                UPDATE Style 
                SET Name = @Name, Description = @Description 
                WHERE ID = @ID";
            Dictionary<string, object> parameters = new()
            {
                { "ID", style.ID},
                { "Name", style.Name},
                { "Description", style.Description },
            };

            return ModifyData(sqlQuery, parameters);
        }

        public static bool InsertPainter(Painter painter)
        {
            string sqlQuery = string.Format(@"
                INSERT INTO Painter (FirstName, LastName, DateOfBirth, {0} {1} Notes) 
                VALUES (@FirstName, @LastName, @DateOfBirth, {2} {3} @Notes)",
                painter.DateOfDeath != null ? " DateOfDeath, " : "",
                painter.Picture != null ? " Picture, " : "",
                painter.DateOfDeath != null ? " @DateOfDeath, " : "",
                painter.Picture != null ? " @Picture, " : "");
            Dictionary<string, object> parameters = new()
            {
                { "FirstName", painter.FirstName},
                { "LastName", painter.LastName },
                { "DateOfBirth", painter.DateOfBirth },
                { "Notes", painter.Notes },
            };

            if (painter.DateOfDeath != null)
            {
                parameters.Add("DateOfDeath", painter.DateOfDeath);
            }

            if (painter.Picture != null)
            {
                parameters.Add("Picture", painter.Picture);
            }

            return ModifyData(sqlQuery, parameters);
        }

        public static List<Painter> LoadPainters()
        {
            List<Painter> items = new();
            DataTable resultTable = LoadData("SELECT ID, FirstName, LastName, DateOfBirth, DateOfDeath, Notes from Painter");

            foreach (DataRow row in resultTable.Rows)
            {
                items.Add(ConvertToPainter(row));
            }
            return items;
        }

        public static Image? LoadPainterPicture(int painterID)
        {
            Image? image = null;
            Dictionary<string, object> parameters = new()
            {
                { "painterID", painterID }
            };

            try
            {
                DataTable data = LoadData(@"
                SELECT Picture
                FROM Painter
                WHERE ID = @painterID ", parameters);

                if (data.Rows.Count > 0)
                {
                    image = ConvertToImage(data.Rows[0]["Picture"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
            }

            return image;
        }


        private static Painter ConvertToPainter(DataRow row)
        {
            object dateOfDeath = row["DateOfDeath"];
            return new Painter
            {
                ID = (int)row["ID"],
                FirstName = (string)row["FirstName"],
                LastName = (string)row["LastName"],
                DateOfBirth = (DateTime)row["DateOfBirth"],
                DateOfDeath = dateOfDeath is DBNull ? null : Convert.ToDateTime(dateOfDeath),
                Notes = (string)row["Notes"],
            };
        }

        public static bool UpdatePainter(Painter painter)
        {
            string sqlQuery = string.Format(@"
                UPDATE Painter 
                SET 
                    FirstName = @FirstName, 
                    LastName = @LastName, 
                    DateOfBirth = @DateOfBirth, 
                    {0} 
                    {1} 
                    Notes = @Notes 
                WHERE ID = @ID",
                painter.DateOfDeath != null ? " DateOfDeath = @DateOfDeath, " : " DateOfDeath = NULL, ",
                painter.Picture != null ? " Picture = @Picture, " : " Picture = NULL, ");
            Dictionary<string, object> parameters = new()
            {
                { "ID", painter.ID},
                { "FirstName", painter.FirstName},
                { "LastName", painter.LastName },
                { "DateOfBirth", painter.DateOfBirth },
                { "Notes", painter.Notes },
            };

            if (painter.DateOfDeath.HasValue)
            {
                parameters.Add("DateOfDeath", painter.DateOfDeath);
            }

            if (painter.Picture != null)
            {
                parameters.Add("Picture", painter.Picture);
            }

            return ModifyData(sqlQuery, parameters);
        }

        public static bool UpdatePainting(Painting painting)
        {
            string sqlQuery = string.Format(@"
                UPDATE Painting
                SET 
                    Name = @Name, 
                    {0} 
                    {1} 
                    {2}
                    {3}
                    Notes = @Notes 
                WHERE ID = @ID",
                painting.CreateDate != null ? " CreateDate = @CreateDate, " : " CreateDate = NULL, ",
                painting.PainterID != null ? " PainterID = @PainterID, " : " PainterID = NULL, ",
                painting.StyleID != null ? " StyleID = @StyleID, " : " StyleID = NULL, ",
                painting.Picture != null ? " Picture = @Picture, " : " Picture = NULL, ");
            Dictionary<string, object> parameters = new()
            {
                { "ID", painting.ID},
                { "Name", painting.Name},
                { "Notes", painting.Notes },
            };

            if (painting.CreateDate.HasValue)
            {
                parameters.Add("CreateDate", painting.CreateDate);
            }

            if (painting.PainterID.HasValue)
            {
                parameters.Add("PainterID", painting.PainterID);
            }

            if (painting.StyleID.HasValue)
            {
                parameters.Add("StyleID", painting.StyleID);
            }

            if (painting.Picture != null)
            {
                parameters.Add("Picture", painting.Picture);
            }

            return ModifyData(sqlQuery, parameters);
        }

        public static Image? LoadPaintingPicture(int paintingID)
        {
            Image? image = null;
            Dictionary<string, object> parameters = new() {
                { "paintingID", paintingID }
            };

            try
            {
                DataTable data = LoadData(@"
                SELECT Picture
                FROM Painting
                WHERE ID = @paintingID ", parameters);

                if (data.Rows.Count > 0)
                {
                    image = ConvertToImage(data.Rows[0]["Picture"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
            }

            return image;
        }

        public static bool InsertPainting(Painting painting)
        {
            string sqlQuery = string.Format(@"
                INSERT INTO Painting ({0} {1} {2} {3} Name, Notes) 
                VALUES ({4} {5} {6} {7} @Name, @Notes)",

                painting.PainterID != null ? " PainterID, " : "",
                painting.StyleID != null ? " StyleID, " : "",
                painting.CreateDate != null ? " CreateDate, " : "",
                painting.Picture != null ? " Picture, " : "",
                painting.PainterID != null ? " @PainterID, " : "",
                painting.StyleID != null ? " @StyleID, " : "",
                painting.CreateDate != null ? " @CreateDate, " : "",
                painting.Picture != null ? " @Picture, " : "");
            Dictionary<string, object> parameters = new()
            {
                { "Name", painting.Name},
                { "Notes", painting.Notes },
            };

            if (painting.PainterID != null)
            {
                parameters.Add("PainterID", painting.PainterID);
            }

            if (painting.StyleID != null)
            {
                parameters.Add("StyleID", painting.StyleID);
            }

            if (painting.CreateDate.HasValue)
            {
                parameters.Add("CreateDate", painting.CreateDate);
            }

            if (painting.Picture != null)
            {
                parameters.Add("Picture", painting.Picture);
            }

            return ModifyData(sqlQuery, parameters);
        }

        public static Painting? LoadPainting(int paintingID)
        {
            PaintingFilter filter = new()
            {
                ID = paintingID
            };
            return LoadPaintings(filter).FirstOrDefault();
        }

        public static List<Painting> LoadPaintings(PaintingFilter? filter = null)
        {
            List<Painting> items = new();
            string sqlSelect = " SELECT Painting.ID, Name, PainterID, StyleID, CreateDate, Painting.Notes from Painting ";
            if (filter?.IncludeAllData ?? false)
            {
                sqlSelect = " SELECT Painting.* from Painting ";
            }

            if (filter?.UserID.HasValue ?? false)
            {
                sqlSelect += " INNER JOIN UserPainting ON Painting.ID = PaintingID ";
            }

            if (!string.IsNullOrWhiteSpace(filter?.PainterName))
            {
                sqlSelect += " INNER JOIN Painter ON Painter.ID = PainterID ";
            }

            Dictionary<string, object> parameters = new();

            if (filter != null)
            {
                sqlSelect += " WHERE 1 = 1 ";
                if (filter.ID.HasValue)
                {
                    sqlSelect += " AND ID = @ID ";
                    parameters.Add("ID", filter.ID);
                }

                if (filter.UserID.HasValue)
                {
                    sqlSelect += " AND UserID = @UserID ";
                    parameters.Add("UserID", filter.UserID);
                }

                if (!string.IsNullOrWhiteSpace(filter.PainterName))
                {
                    sqlSelect += " AND (Painter.FirstName LIKE @PainterName OR Painter.LastName LIKE @PainterName) ";
                    parameters.Add("PainterName", $"%{filter.PainterName}%");
                }

                if (!string.IsNullOrWhiteSpace(filter.PaintingName))
                {
                    sqlSelect += " AND Name LIKE @PaintingName ";
                    parameters.Add("PaintingName", $"%{filter.PaintingName}%");
                }

                if (filter.StyleID.HasValue)
                {
                    sqlSelect += " AND StyleID = @StyleID ";
                    parameters.Add("StyleID", filter.StyleID);
                }
            }


            DataTable resultTable = LoadData(sqlSelect, parameters);

            foreach (DataRow row in resultTable.Rows)
            {
                items.Add(ConvertToPainting(row, filter));
            }
            return items;
        }

        private static Painting ConvertToPainting(DataRow row, PaintingFilter? filter = null)
        {
            object createDate = row["CreateDate"];
            object painterID = row["PainterID"];
            object styleID = row["StyleID"];
            object pictureData = null;
            if (filter?.IncludeAllData ?? false)
            {
                pictureData = row["Picture"];
            }
            Painting painting = new()
            {
                ID = (int)row["ID"],
                Name = (string)row["Name"],
                PainterID = painterID is DBNull ? null : Convert.ToInt32(painterID),
                StyleID = styleID is DBNull ? null : Convert.ToInt32(styleID),
                CreateDate = createDate is DBNull ? null : Convert.ToDateTime(createDate),
                Notes = (string)row["Notes"],
            };

            if (pictureData != null && (pictureData is not DBNull))
            {
                painting.Picture = (byte[])pictureData;
            }

            return painting;
        }

        public static bool DeletePainting(int paintingID)
        {
            string sqlQuery = @"
                DELETE Painting 
                WHERE ID = @paintingID";

            Dictionary<string, object> parameters = new()
            {
                { "paintingID", paintingID }
            };

            return ModifyData(sqlQuery, parameters);
        }

        internal static bool DeletePainter(int painterID)
        {
            string sqlQuery = @"
                DELETE Painter 
                WHERE ID = @painterID";

            Dictionary<string, object> parameters = new()
            {
                { "painterID", painterID }
            };

            return ModifyData(sqlQuery, parameters);
        }

        public static void SetFavorite(int userID, int paintingID, bool isFavorite)
        {
            if (isFavorite && GetFavorite(userID, paintingID))
                return;

            string sqlQuery;
            if (isFavorite)
            {
                sqlQuery = @"
                    INSERT INTO UserPainting (UserID, PaintingID) 
                    VALUES (@UserID, @PaintingID)";
            }
            else
            {
                sqlQuery = @"
                    DELETE UserPainting 
                    WHERE UserID = @UserID AND PaintingID = @PaintingID";
            }

            Dictionary<string, object> parameters = new()
            {
                { "userID", userID },
                { "paintingID", paintingID }
            };

            ModifyData(sqlQuery, parameters);
        }

        public static bool GetFavorite(int userID, int paintingID)
        {
            Dictionary<string, object> parameters = new()
            {
                { "userID", userID },
                { "paintingID", paintingID }
            };
            return LoadData(@"
                SELECT TOP 1 1 
                FROM UserPainting 
                WHERE UserID = @UserID AND PaintingID = @PaintingID", parameters).Rows.Count > 0;
        }

        public static bool UpdateUser(Entity.User user)
        {
            string sqlQuery = string.Format(@"
                UPDATE [User] 
                SET 
                    Username = @Username, 
                    {0} 
                    {1} 
                    Email = @Email
                WHERE ID = @ID",
                !string.IsNullOrWhiteSpace(user.Password) ? " Password = @Password, " : "",
                user.Picture != null ? " Photo = @Picture, " : " Photo = NULL, ");
            Dictionary<string, object> parameters = new()
            {
                { "ID", user.ID},
                { "Username", user.Username},
                { "Email", user.Email },
            };

            if (!string.IsNullOrWhiteSpace(user.Password))
            {
                parameters.Add("Password", user.Password);
            }

            if (user.Picture != null)
            {
                parameters.Add("Picture", user.Picture);
            }

            return ModifyData(sqlQuery, parameters);
        }

        public static Image? LoadUserPicture(int userID)
        {
            Image? image = null;
            Dictionary<string, object> parameters = new() {
                { "userID", userID }
            };

            try
            {
                DataTable data = LoadData(@"
                SELECT Photo
                FROM [User]
                WHERE ID = @userID ", parameters);

                if (data.Rows.Count > 0)
                {
                    image = ConvertToImage(data.Rows[0]["Photo"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("DB error occurred. Please try again." + e.Message, "Error");
            }

            return image;
        }

        public static Painter? LoadPainter(int painterID)
        {
            Painter? painter = null;
            Dictionary<string, object> parameters = new() {
                { "painterID", painterID }
            };
            DataTable resultTable = LoadData(@"
                SELECT ID, FirstName, LastName, DateOfBirth, DateOfDeath, Notes 
                FROM Painter
                WHERE ID = @painterID", parameters);

            if (resultTable.Rows.Count > 0)
            {
                painter = ConvertToPainter(resultTable.Rows[0]);
            }
            return painter;
        }
    }
}
