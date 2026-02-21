// using System;
// using Microsoft.Data.SqlClient;

// namespace DataBaseConnection.HealthClinic
// {
//     public class ClinicService : IClinicService
//     {
//         public void ViewPatients()
//         {
//             using SqlConnection con = DbUtil.GetConnection();
//             con.Open();

//             string query = "SELECT patient_id, name, phone FROM Patient";
//             using SqlCommand cmd = new SqlCommand(query, con);
//             using SqlDataReader reader = cmd.ExecuteReader();

//             Console.WriteLine("\n--- PATIENT LIST ---");
//             while (reader.Read())
//             {
//                 Console.WriteLine(
//                     reader["patient_id"] + " " +
//                     reader["name"] + " " +
//                     reader["phone"]
//                 );
//             }
//         }

//         public void AddPatient()
//         {
//             Console.Write("Enter Name: ");
//             string name = Console.ReadLine();

//             Console.Write("Enter Phone: ");
//             string phone = Console.ReadLine();

//             using SqlConnection con = DbUtil.GetConnection();
//             con.Open();

//             string query = "EXEC sp_AddPatient @name, NULL, @phone, NULL, NULL, NULL";
//             using SqlCommand cmd = new SqlCommand(query, con);

//             cmd.Parameters.AddWithValue("@name", name);
//             cmd.Parameters.AddWithValue("@phone", phone);

//             cmd.ExecuteNonQuery();
//             Console.WriteLine("Patient added successfully");
//         }

//         public void ViewDailyAppointments()
//         {
//             Console.Write("Enter date (yyyy-mm-dd): ");
//             string date = Console.ReadLine();

//             using SqlConnection con = DbUtil.GetConnection();
//             con.Open();

//             string query = "EXEC sp_ViewDailySchedule @date";
//             using SqlCommand cmd = new SqlCommand(query, con);
//             cmd.Parameters.AddWithValue("@date", date);

//             using SqlDataReader reader = cmd.ExecuteReader();

//             Console.WriteLine("\n--- DAILY APPOINTMENTS ---");
//             while (reader.Read())
//             {
//                 Console.WriteLine(
//                     reader["patient_name"] + " | " +
//                     reader["doctor_name"] + " | " +
//                     reader["appointment_time"]
//                 );
//             }
//         }

//         /* =======================
//            DOCTOR + SPECIALTY
//            ======================= */

//         public void AddDoctor()
//         {
//             Console.Write("Doctor Name: ");
//             string name = Console.ReadLine();

//             Console.Write("Contact: ");
//             string contact = Console.ReadLine();

//             Console.Write("Consultation Fee: ");
//             decimal fee = decimal.Parse(Console.ReadLine());

//             Console.Write("Specialty ID: ");
//             int specialtyId = int.Parse(Console.ReadLine());

//             using SqlConnection con = DbUtil.GetConnection();
//             con.Open();

//             string query = @"
//                 INSERT INTO Doctor(name, contact, consultation_fee, specialty_id)
//                 VALUES (@name, @contact, @fee, @specialtyId)";

//             using SqlCommand cmd = new SqlCommand(query, con);
//             cmd.Parameters.AddWithValue("@name", name);
//             cmd.Parameters.AddWithValue("@contact", contact);
//             cmd.Parameters.AddWithValue("@fee", fee);
//             cmd.Parameters.AddWithValue("@specialtyId", specialtyId);

//             cmd.ExecuteNonQuery();
//             Console.WriteLine("Doctor added successfully");
//         }

//         public void ViewDoctorsBySpecialty()
//         {
//             Console.Write("Enter Specialty Name: ");
//             string specialty = Console.ReadLine();

//             using SqlConnection con = DbUtil.GetConnection();
//             con.Open();

//             string query = @"
//                 SELECT d.doctor_id, d.name, d.contact, d.consultation_fee
//                 FROM Doctor d
//                 JOIN Specialty s ON d.specialty_id = s.specialty_id
//                 WHERE s.specialty_name = @specialty
//                   AND d.is_active = 1";

//             using SqlCommand cmd = new SqlCommand(query, con);
//             cmd.Parameters.AddWithValue("@specialty", specialty);

//             using SqlDataReader reader = cmd.ExecuteReader();

//             Console.WriteLine("\n--- DOCTORS BY SPECIALTY ---");
//             while (reader.Read())
//             {
//                 Console.WriteLine(
//                     reader["doctor_id"] + " " +
//                     reader["name"] + " " +
//                     reader["contact"] + " " +
//                     reader["consultation_fee"]
//                 );
//             }
//         }
//     }
// }
