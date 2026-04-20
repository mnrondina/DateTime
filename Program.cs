// See https://aka.ms/new-console-template for more information

DateTime hoy = DateTime.Today;

Console.WriteLine(DateTime.Now); // Fecha y Hora actual
Console.WriteLine(DateTime.Today); // Solo fecha. Hora en 00:00, para ver fecha corta se usa ToShortDateString()

/* CREAR FECHAS:

Forma A: Pasando números (año,mes,dia) */

DateTime navidad = new DateTime (2026,12,25);

// Forma B: Parseando un texto

DateTime nuevoAnio = DateTime.Parse ("31/12/2026");

Console.WriteLine($"Año nuevo es {nuevoAnio.ToShortDateString()} y cae {nuevoAnio.DayOfWeek}");

// SUMAR FECHAS: Siempre hay que guardarlas en variables.

DateTime miFecha = DateTime.Today;
DateTime fechaFuturo = miFecha.AddDays(20);
DateTime fechaPasada = miFecha.AddDays(-2);
DateTime mesPosterior = miFecha.AddMonths(1);

Console.WriteLine($"Mi fecha: {miFecha},futuro: {fechaFuturo}, fecha pasada {fechaPasada},mes posterior: {mesPosterior}");

// RESTAR FECHAS: TIMESPAN (lapso de tiempo)

DateTime nacimiento = new DateTime(1988,11,22);
TimeSpan tiempoVivido = DateTime.Today - nacimiento;

Console.WriteLine($"Días Vividos: {tiempoVivido.Days}");