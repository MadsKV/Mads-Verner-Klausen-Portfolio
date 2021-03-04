using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace examples
{
    public class Database
    {
        #region Database
        static SqlConnection connection;
        public static bool Connect(string username, string password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-CHHJASV\MSQLSERVERDEV";
            builder.UserID = username;
            builder.Password = password;
            //builder.IntegratedSecurity = true;
            builder.InitialCatalog = "School101";

            connection = new SqlConnection(builder.ToString());
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {

            }

            return false;
        }
        #endregion
        #region Student
        public static void InsertNewStudent(Student studentBuffer)
        {
            using SqlCommand command = new SqlCommand(@"
            INSERT INTO Student (StudentFirstName, StudentLastName, StudentAge, ClassID)
            VALUES (@StudentFirstName, @StudentLastName, @StudentAge, @ClassID)", connection);
            {
                command.Parameters.AddWithValue("@StudentFirstName", studentBuffer.StudentFirstName);
                command.Parameters.AddWithValue("@StudentLastName", studentBuffer.StudentLastName);
                command.Parameters.AddWithValue("@StudentAge", studentBuffer.StudentAge);
                command.Parameters.AddWithValue("@ClassID", studentBuffer.ClassID);
                try
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception e)
                {
                    
                }
            }
        }
        public static Dictionary<int, string> Fill_ClassID()
        {
            string sql = (@"SELECT ID, Name FROM Class");

            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> ClassName = new Dictionary<int, string>();
            while (reader.Read())
            {
                ClassName.Add(reader.GetInt32(0),reader.GetString(1));
            }
            reader.Close();
            return ClassName;
        }
        public static List<Student> FillGrid()
        {
            List<Student> students = new List<Student>();
            string sql = (@"SELECT StudentID, StudentFirstName, StudentlastName, StudentAge, Class.Name FROM Student
                            INNER JOIN Class ON Student.ClassID = Class.ID");

            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();
            {
                while (reader.Read())
                {
                    Student student = new Student();
                    student.StudentID = reader.GetInt32(0);
                    student.StudentFirstName = reader.GetString(1);
                    student.StudentLastName = reader.GetString(2);
                    student.StudentAge = reader.GetInt32(3);
                    student.Name = reader.GetString(4);

                    students.Add(student);
                }
                reader.Close();
                return students;
            }
        }
        #endregion
        #region Teacher
        public static void InsertNewTeacher(Teacher teacherBuffer)
        {
            using SqlCommand command = new SqlCommand(@"
            INSERT INTO TeacherN (TeacherFirstName, TeacherLastName, TeacherAge, TeacherMail, SubjectID)
            VALUES (@TeacherFirstName, @TeacherLastName, @TeacherAge, @TeacherMail, @SubjectID)", connection);
            {
                command.Parameters.AddWithValue("@TeacherFirstName", teacherBuffer.TeacherFirstName);
                command.Parameters.AddWithValue("@TeacherLastName", teacherBuffer.TeacherLastName);
                command.Parameters.AddWithValue("@TeacherAge", teacherBuffer.TeacherAge);
                command.Parameters.AddWithValue("@TeacherMail", teacherBuffer.TeacherMail);
                command.Parameters.AddWithValue("@SubjectID", teacherBuffer.SubjectID);

                try
                {
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {

                }
            }
        }
        public static Dictionary<int, string> Fill_TeacherDiscipline()
        {
            string sql = (@"SELECT SubjectID, SubjectName FROM Subject");

            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> SubjectName = new Dictionary<int, string>();
            while (reader.Read())
            {
                SubjectName.Add(reader.GetInt32(0), reader.GetString(1));
            }
            reader.Close();
            return SubjectName;
        }
        #endregion

    }
}
