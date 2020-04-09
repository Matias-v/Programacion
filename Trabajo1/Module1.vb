Module Module1

    Sub Main()
#Region "VariablesyObjetos"
        Dim empleado1 As New Logica.Empleado(110, "Pepe", "Argento", "La casa de pepe", 30000.0, "administrador")
        Dim empleado2 As New Logica.Empleado(111, "Damian", "Artigas", "La casa de Damian", 20000.0, "operario")
        Dim empleado3 As New Logica.Empleado(100, "Marcelo", "Tinelli", "Showmatch", 40000.0, "gerente")
        Dim op As Integer
        Dim totalA As Double
#End Region
#Region "Menu"

        Do
            Console.WriteLine("-----------------------")
            Console.WriteLine("Menu")
            Console.WriteLine("1.Registro de empleados")
            Console.WriteLine("2.Importe total a pagar por sueldos")
            Console.WriteLine("0.Salir")
            Console.Write("Opcion:")
            op = Integer.Parse(Console.ReadLine())
            Console.WriteLine("-----------------------")
            Select Case op
                Case 1
                    Console.WriteLine("-----------------------")
                    Console.WriteLine("   Empleados     ")
                    Console.Write(empleado1.ToString())
                    telefonos(0,2)
                    Console.Write(empleado2.ToString())
                    telefonos(3,5)
                    Console.Write(empleado3.ToString())
                    telefonos(6,9)
                    Console.WriteLine("-----------------------")
                Case 2
                    Console.WriteLine("-----------------------")
                    Console.WriteLine("   Empleados     ")
                    Console.WriteLine(empleado1.ToString())
                    Console.WriteLine(empleado2.ToString())
                    Console.WriteLine(empleado3.ToString())
                    Console.Write("Total a pagar:")
                    totalA = empleado1.CalculoSueldo() + empleado2.CalculoSueldo() + empleado3.CalculoSueldo()
                    Console.WriteLine("-----------------------")
                    Console.WriteLine(totalA)
                    Console.WriteLine("-----------------------")
            End Select
        Loop Until op = 0
#End Region
        Console.ReadLine()
    End Sub

End Module
