// using System;

// namespace DataBaseConnection.HealthClinic
// {
//     public class ClinicMenu
//     {
//         private IClinicService service;

//         public ClinicMenu()
//         {
//             service = new ClinicService();
//         }

//         public void ShowMenu()
//         {
//             while (true)
//             {
//                 Console.WriteLine("\n====== HEALTH CLINIC MENU ======");
//                 Console.WriteLine("1. View Patients");
//                 Console.WriteLine("2. Add Patient");
//                 Console.WriteLine("3. View Daily Appointments");
//                 Console.WriteLine("4. Add Doctor");
//                 Console.WriteLine("5. View Doctors by Specialty");
//                 Console.WriteLine("0. Exit");
//                 Console.Write("Enter choice: ");

//                 if (!int.TryParse(Console.ReadLine(), out int choice))
//                 {
//                     Console.WriteLine("Invalid input");
//                     continue;
//                 }

//                 switch (choice)
//                 {
//                     case 1:
//                         service.ViewPatients();
//                         break;

//                     case 2:
//                         service.AddPatient();
//                         break;

//                     case 3:
//                         service.ViewDailyAppointments();
//                         break;

//                     case 4:
//                         service.AddDoctor();
//                         break;

//                     case 5:
//                         service.ViewDoctorsBySpecialty();
//                         break;

//                     case 0:
//                         Console.WriteLine("Exiting application...");
//                         return;

//                     default:
//                         Console.WriteLine("Invalid choice");
//                         break;
//                 }
//             }
//         }
//     }
// }
