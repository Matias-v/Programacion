Public Class Principal
    Sub main()

        Dim empleado1 As New Empleado(110, "Pepe", "Argento", "La casa de pepe", 1234, 30000.0, "administrador")
        Dim empleado2 As New Empleado(111, "Damian", "Artigas", "La casa de Damian", 1222, 20000.0, "operario")
        Dim empleado3 As New Empleado(100, "Marcelo", "Tinelli", "Showmatch", 2020, 40000.0, "gerente")
        Dim op As Integer

        Console.WriteLine("Menu")
        Console.WriteLine("1.Registro de empleados")
        Console.WriteLine("2.Calcular sueldos")
        Console.WriteLine("0.Salir")
        Console.Write("Opcion:")
        op = Integer.Parse(Console.ReadLine())

        Select Case op
            Case 1
                Console.WriteLine(empleado1.ToString())

            Case 2
                Console.WriteLine("Prueba")
            Case 0

        End Select






        Console.ReadLine()
    End Sub
End Class
