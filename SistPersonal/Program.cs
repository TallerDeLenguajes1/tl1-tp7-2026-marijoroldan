using DatosEmpleado;

DateTime fechaNac;
string fechaProvisoria;
bool fechaValida;
Empleado[] arrEmp = new Empleado[3];

//==================================================================================
//                        ACA INGRESO LOS DATOS MANUALMENTE
//==================================================================================

// for (int i = 0; i < 3; i++)
// {
//     Empleado miEmpleado = new Empleado();
//     miEmpleado.Nombre = "Maria";
//     miEmpleado.Apellido = "Roldán";
//     arrEmp[i]=miEmpleado;
// }
// =================================================================================
//                   ESTO HAGO SI QUIERO QUE EL USUARIO INGRESE DATOS
// =================================================================================
for (int i = 0; i < 3; i++)
{
    arrEmp[i] = new Empleado();
    Console.WriteLine("INGRESO DE DATOS DEL EMPLEADO");
    Console.WriteLine("Nombre: ");
    arrEmp[i].Nombre = Console.ReadLine();
    Console.WriteLine("Apellido: ");
    arrEmp[i].Apellido = Console.ReadLine();
    Console.WriteLine("Fecha de Nacimiento: ");

    do
    {
        Console.Write("Ingrese fecha de nacimiento (DD/MM/AAAA): ");
        fechaProvisoria = Console.ReadLine();

        // Intenta traducir el texto 'entrada' y si puede, guarda el objeto en 'fechaNac'
        fechaValida = DateTime.TryParse(fechaProvisoria, out fechaNac);

        if (!fechaValida)
        {
            Console.WriteLine("¡Formato incorrecto! Use números separados por barras (Ej: 15/07/2002).");
        }
    } while (!fechaValida);

    // Una vez que salió del do-while, guardás esa fecha limpia en la propiedad del empleado
    arrEmp[i].FechaNacimiento = fechaNac;

    Console.WriteLine("Estado Civil: ");
    arrEmp[i].EstadoCivil=Console.ReadLine();
    
}

foreach (Empleado emp in arrEmp)
{
    Console.WriteLine("===========================================");
    Console.WriteLine("                  DATOS DEL EMPLEADO ");
    Console.WriteLine("===========================================");
    Console.WriteLine($"Nombre: " + emp.Nombre);
    Console.WriteLine("Apellido: " + emp.Apellido);
}