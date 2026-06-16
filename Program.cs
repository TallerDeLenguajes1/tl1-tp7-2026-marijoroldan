using EspacioCalculadora; // Conectamos con tu clase Calculadora

Calculadora miCalc = new Calculadora(); // Creamos la instancia

// DECLARO E INICIALIZO VARIABLES
string opcion, numPrincipal;
int opcionValidada;
bool EsOperacionValida, todoOK, EsNumeroValido;
double num = 0;


// =================================================================
// 1. EL GRAN BUCLE PRINCIPAL (Controla la fluidez de toda la app)
// =================================================================
do
{
    // Al inicio de cada vuelta, le mostramos el estado actual al usuario
    Console.WriteLine($"\n---------------------------------");
    Console.WriteLine($"RESULTADO ACTUAL: {miCalc.Resultado}");
    Console.WriteLine($"---------------------------------");

    // SUB-BUCLE A: Validar que elija una opción correcta (0 al 5)
    do
    {
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar \n2. Restar \n3. Multiplicar \n4. Dividir \n5. Limpiar \n0. Salir");
        Console.Write("Opción: ");
        opcion = Console.ReadLine();
        
        EsOperacionValida = int.TryParse(opcion, out opcionValidada);
        
        if (!EsOperacionValida || opcionValidada < 0 || opcionValidada > 5)
        {
            Console.WriteLine("¡Opción inválida! Intente de nuevo.");
        }
    } while (!EsOperacionValida || opcionValidada < 0 || opcionValidada > 5);

    // Si el usuario eligió 0, salimos inmediatamente sin pedir números
    if (opcionValidada == 0)
    {
        break; 
    }

    // SUB-BUCLE B: Solicitar y validar el número (Solo si es una operación matemática 1 a 4)
    if (opcionValidada >= 1 && opcionValidada <= 4)
    {
        do
        {
            Console.Write("Ingrese un número para la operación: ");
            numPrincipal = Console.ReadLine();
            EsNumeroValido = double.TryParse(numPrincipal, out num);

            if (opcionValidada == 4) // Si es división, controlamos que no sea cero
            {
                if (!EsNumeroValido || num == 0)
                {
                    Console.WriteLine("¡Error! No se puede dividir por cero o el formato es incorrecto.");
                    todoOK = false;
                }
                else
                {
                    todoOK = true;
                }
            }
            else
            {
                todoOK = EsNumeroValido;
                if (!todoOK) Console.WriteLine("¡Error! Ingrese un número con formato válido.");
            }
        } while (!todoOK);
    }


    var _ = opcionValidada switch
    {
        1 => execute(() => miCalc.Sumar(num)),
        2 => execute(() => miCalc.Restar(num)),
        3 => execute(() => miCalc.Multiplicar(num)),
        4 => execute(() => miCalc.Dividir(num)),
        5 => execute(() => { miCalc.Limpiar(); Console.WriteLine("Calculadora reseteada."); }),
        _ => execute(() => Console.WriteLine("Opción no válida"))
    };

} while (opcionValidada != 0); 

Console.WriteLine("\n¡Gracias por usar la calculadora! Programa finalizado.");

// =================================================================
//                           FUNCIÓN AUXILIAR 
// =================================================================
static bool execute(Action action) 
{ 
    action(); 
    return true; 
}
