# EJERCICIOS-DE-LOGIN-UNO-DE-CONSOLA
using System;

namespace login_consola
{
    class Program
    {
        static void Main(string[] args)
        
        
        {                      /////////////      menu    //////////////
            /*      ojo con los usuarios, contraseñas, roll, estado y fecha de creacion.
             *
             *                     TABLA DE CARACTERISTICAS DE USUARIOS
              ---------------------------------------------------------------------------------------------
              | NOMBRES  | USUARIOS/CEDUAS    | CONTRASEÑA |      ROLL     |  ESTADO  | FECHA DE CREACION |
              |----------|--------------------|------------|---------------|----------|-------------------|
              |   Luis   |   40229363458      |   223445   | ADMINISTRADOR | activo   |  10 /01/ 2001     |
              |----------|--------------------|------------|---------------|----------|-------------------|
              |   Jose   |   40330129321      |   427554   | SUPERVISOR    | activo   |  30 /06/ 2003     |
              |----------|--------------------|------------|---------------|----------|-------------------|
              |   Juan   |   40124304839      |   981341   | VENDEDOR      | inactivo |  18 /05/ 2020     |
              ---------------------------------------------------------------------------------------------
             */

            // variables 
            //               usuarios 
            long User1 = 40229363458;
            long User2 = 40330129321;
            // como el tercer usuario esta inactivo no hace nada 

            //             fecha de creacion de usuarios 
            DateTime usuario1 = DateTime.Today;
            DateTime usuario2 = DateTime.Today;

            //          variable bool para verificar los estados 
            bool estado = false;

            //      variable donde el usuario ingresara el usuario y la contraseña 
            string usuario;
            int contraseña = 0;

            // le decimos al usuario que ingrese una opcion para  proceder 
            // variable para hacer el bucle 
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---------- INGRESE UNA OPCION -----------------");
            Console.WriteLine("--          1-INICIAR SESION                 --");
            Console.WriteLine("--          2-SALIR                          --");
            Console.WriteLine("-----------------------------------------------");
            int opcion = Convert.ToInt32(Console.ReadLine());

            //              bucle 
            while (opcion == 1)
            {//              ingresamos los datos 
                Console.WriteLine(" INGRESE SU CEDULA : ");
                usuario = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(" INGRESE LA CONTRASEÑA ");
                contraseña = Convert.ToInt32(Console.ReadLine());

                //                ADMINISTRADOR 
                if ((usuario == "40229363458") && (contraseña == 223445))
                {
                    estado = true;
                    if (estado == true)
                    {
                        Console.WriteLine(" ACABAS DE INGRESAR CON EL USUARIO:" + "\n" + " Luis Taveras " +
                            User1 + " y su Roll es: ADMINISTRADOR creado el " + usuario1);
                        break;
                    }
                }
                //                        SUPERVISOR 
                else if ((usuario == "40330129321") && (contraseña == 427554))
                {
                    estado = true;
                    if (estado == true)
                    {
                        Console.WriteLine(" ACABAS DE INGRESAR CON EL USUARIO:" + "\n" + " Jose Deschamps " +
                            User2 + " y su Roll es: SUPERVISOR creado el " + usuario2);
                        break;
                    }
                }
                //           VENDEDOR  ( inactivo ) !!!!!!!!!
                else if ((usuario == "40124304839") && (contraseña == 981341))
                {
                    estado = false;
                    if (estado == false)
                    {
                        Console.WriteLine("USUARIO INACTIVO, VALIDAR CON OTRO USUARIO ");
                        Console.WriteLine(" ¿desea continuar?");
                        Console.WriteLine(" pulse 1 para continuar ");
                        Console.WriteLine(" pulse 2 para salir ");
                        int opcion2 = Convert.ToInt32(Console.ReadLine());
                        if (opcion2 == 2)
                        { break; }
                    }
                }
                //         SI NO SE COMPLEN NINGUNA DE LAS CONDICIONES 
                else
                {
                    Console.WriteLine("Contraseña o Usuario incorrectos favor verificar");
                    Console.WriteLine(" ¿desea continuar?");
                    Console.WriteLine(" pulse 1 para continuar ");
                    Console.WriteLine(" pulse 2 para salir ");
                    int opcion3 = Convert.ToInt32(Console.ReadLine());
                    if (opcion3 == 2)
                    { break; }
                }
            }
        }
    }
}
