using System;

namespace DataBaseConnection.HealthClinic
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClinicMenu menu = new ClinicMenu();
            menu.ShowMenu();
        }
    }
}
