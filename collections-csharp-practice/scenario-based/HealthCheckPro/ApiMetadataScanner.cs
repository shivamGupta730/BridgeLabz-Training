using System;
using System.Linq;
using System.Reflection;

public class ApiMetadataScanner
{
    public static void ScanControllers()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        var controllers = assembly.GetTypes()
            .Where(t => t.IsClass && t.Name.EndsWith("Controller"));

        foreach (var controller in controllers)
        {
            Console.WriteLine($"Controller: {controller.Name}");

            var methods = controller.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                bool hasPublicApi = method.GetCustomAttribute<PublicAPIAttribute>() != null;
                bool hasAuth = method.GetCustomAttribute<RequiresAuthAttribute>() != null;

                Console.Write($"  Method: {method.Name}");

                if (!hasPublicApi && !hasAuth)
                {
                    Console.WriteLine("  Missing Annotations");
                }
                else
                {
                    Console.Write(" ✔ ");

                    if (hasPublicApi) Console.Write("@PublicAPI ");
                    if (hasAuth) Console.Write("@RequiresAuth ");

                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
