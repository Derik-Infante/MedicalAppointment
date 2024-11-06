

using MedicalAppointmentApp.Domain.Entities.System;
using MedicalAppointmentApp.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MedicalAppointmentApp.Persistance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Crear una instancia de la clase PruebaInsercion
            var prueba = new PruebaInsercion();

            // Ejecutar la prueba de inserción
            prueba.EjecutarPrueba();

            // Mantener la consola abierta para ver el resultado
            Console.ReadLine(); // Esto es opcional, para que la ventana de la consola no se cierre inmediatamente
        }
    }
    public class PruebaInsercion
    {
        public void EjecutarPrueba()
        {
            // Configuración de servicios para inyectar el DbContext
            var serviceProvider = new ServiceCollection().AddDbContext<MedicalAppointmentsContext>(options => options.UseMySql("Server=localhost;Database=sistema;User ID=root;Password=062403;",
            new MySqlServerVersion(new Version(8, 4, 2)))) // Asegúrate de usar la versión correcta de MySQL
            .BuildServiceProvider();

            // Obtener una instancia de DbContext
            using (var context = serviceProvider.GetService<MedicalAppointmentsContext>())
            {
                try
                {
                    // Crear una instancia de la entidad y asignar valores
                    var nuevoRegistro = new Notifications
                    {
                        Message = "Prueba",
                        NotificationID = 53453,
                        UserID = 42343
                    };

                    // Agregar el registro al contexto
                    context.Notifications.Add(nuevoRegistro);

                    // Guardar los cambios en la base de datos
                    context.SaveChanges();
                    Console.WriteLine("Registro insertado correctamente.");
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                }
            }
        }
    }
}
