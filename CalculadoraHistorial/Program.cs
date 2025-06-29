using EspacioCalculadora;

Calculadora calc = new Calculadora();

calc.Sumar(10);
calc.Multiplicar(2);
calc.Restar(5);
calc.Dividir(3);
calc.Limpiar();

System.Console.WriteLine($"Resultado final: {calc.Resultado()}");

System.Console.WriteLine("\nHistorial de operaciones:");
MostrarHistorial(calc);

 void MostrarHistorial(Calculadora calc)
{
    foreach (var op in calc.historial)
    {
        System.Console.WriteLine($"Operacion: {op.Tipo_operacion} entre {op.ResultadoAnterior} y {op.NuevoValor}, Resultado : {op.Resultado}");
    }
}