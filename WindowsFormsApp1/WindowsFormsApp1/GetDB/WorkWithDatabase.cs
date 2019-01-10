using AutoSendBirhDayMail.Model;
using AutoSendMailService.MailService;
using AutoSendMailService.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;

namespace AutoSendMailService
{
    class WorkWithDatabase
    {
        private static string sql = "Select * from NHANVIEN nv left join LOAI_NV l on l.LOAINV_ID=nv.LOAINV_ID ";
        private static string sql1 = "Select * from adBirthdayTemplate ";
        private static MailConfig mailConfig = null;
        public WorkWithDatabase(MailConfig _mailConfig)
        {
            mailConfig = _mailConfig;
        }
       
        public static string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }


        public List<Employee> QueryEmployee(string serverName, string dataBaseName, string userName, string pass)
        {
            // Lấy ra đối tượng Connection kết nối vào DB.
            SqlConnection conn = DBSQLServerUtils.GetDBConnection(serverName, dataBaseName, userName, pass);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql;
                List<Employee> employee = new List<Employee>();


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            if (reader.GetDateTime(12).Month == 1 && reader.GetDateTime(12).Day == 4)
                            //if (reader.GetDateTime(12).Month == DateTime.Now.Month && reader.GetDateTime(12).Day == DateTime.Now.Day)
                            {
                                Employee employee1 = new Employee(
                                reader.GetInt32(3),
                                reader.GetDateTime(12),
                                SafeGetString(reader, 5),
                                SafeGetString(reader, 36),
                                reader.IsDBNull(15) ? "" : (bool)reader["GioiTinh"] ? "Anh" : "Chị"
                               );
                                employee.Add(employee1);

                            }
                        }
                    }

                }
                return employee;
            }
            catch (SqlException e)
            {
                throw e;

            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }
        }

        public List<Template> QueryBirth(string serverName, string dataBaseName, string userName, string pass)
        {
            SqlConnection conn = DBSQLServerUtils.GetDBConnection(serverName, dataBaseName, userName, pass);
            try
            {
                conn.Open();
                // Tạo một đối tượng Command.
                SqlCommand cmd = new SqlCommand();

                // Liên hợp Command với Connection.
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                List<Template> temPlate = new List<Template>();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Template template1 = new Template(
                                reader.GetInt32(0),
                                 SafeGetString(reader, 1),
                                 SafeGetString(reader, 2)
                                );
                            temPlate.Add(template1);
                        }
                    }
                }
                return temPlate;
            }
            catch (SqlException e)
            {
                throw e;

            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }

        }

        public void setUpSendMail(List<Employee> employee, List<Template> templates)
        {
            //DateTime date = new DateTime();
            SendMail sendMail = new SendMail();
            SmtpClient smtp = mailConfig.buildSmtpClient();
            List<MailMessage> mailMessages = new List<MailMessage>();
            foreach (Employee element in employee)
            {
                Random random = new Random();
                int temp = random.Next(0, 12);
                sql1 += temp;

                string template = templates[temp].getTemPlate();
                template = template.Replace("[Var1]", element.getName());
                template = template.Replace("[Var2]", element.getSex());
                template = template.Replace("[Var3]", element.getDateOfBirth().Day + "/" + element.getDateOfBirth().Month);
                template = template.Replace("[Var4]", element.getEmployeeType());
                string image = "<div><img style='width:100%' src=cid:myImageID></div>";

                mailMessages.Add(mailConfig.buildMailMessageWithImage(templates[temp].getFileName(), template + image, "[Bsi.all]BSi\\CHUC MUNG SINH NHAT"));

            }

            //sendMail

            foreach (MailMessage mailMessage in mailMessages)
            {
                sendMail.SendMailAsync(smtp, mailMessage);
            }
        }
    }
}
