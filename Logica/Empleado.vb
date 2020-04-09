Public Class Empleado
    Private ci As Integer
    Private nom As String
    Private ape As String
    Private dir As String
    Private tel1, tel2, tel3 As Integer
    Private sueldoMens As Double
    Private tipo As String

    Public Sub New(ci As Integer, nom As String, ape As String, dir As String, tel1 As Integer, tel2 As Integer, sueldoMens As Double, tipo As String)
        Me.ci = ci
        Me.nom = nom
        Me.ape = ape
        Me.dir = dir
        Me.tel1 = tel1
        Me.tel2 = tel2
        Me.sueldoMens = sueldoMens
        Me.tipo = tipo

    End Sub

    Public Property propCi() As Integer
        Get
            Return ci
        End Get
        Set(value As Integer)
            Me.ci = ci
        End Set
    End Property

    Public Property propNom As String
        Get
            Return nom
        End Get
        Set(value As String)
            Me.nom = nom
        End Set
    End Property

    Public Property propApe As String
        Get
            Return ape
        End Get
        Set(value As String)
            Me.ape = ape
        End Set
    End Property

    Public Property propDir As String
        Get
            Return dir
        End Get
        Set(value As String)
            Me.dir = dir
        End Set
    End Property

    Public Property propTel1 As Integer
        Get
            Return tel1
        End Get
        Set(value As Integer)
            Me.tel1 = tel1
        End Set
    End Property

    Public Property propTel2 As Integer
        Get
            Return tel2
        End Get
        Set(value As Integer)
            Me.tel2 = tel2
        End Set
    End Property
    Public Property propSueldoMens As Double
        Get
            Return sueldoMens
        End Get
        Set(value As Double)
            Me.sueldoMens = sueldoMens
        End Set
    End Property

    Public Property propTipo As String
        Get
            Return tipo
        End Get
        Set(value As String)
            Me.tipo = tipo
        End Set
    End Property

    Public Function CalculoSueldo() As Double
        Dim sueldoTotal, porcentaje As Double
        If tipo Is "gerente" Then
            porcentaje = sueldoMens * 0.97
            sueldoTotal = sueldoMens + porcentaje
            Return sueldoTotal
        End If
        If tipo Is "administrador" Then
            porcentaje = sueldoMens * 0.27
            sueldoTotal = sueldoMens + porcentaje
            Return sueldoTotal
        End If
        If tipo Is "operario" Then
            porcentaje = sueldoMens * 0.38
            sueldoTotal = sueldoMens + porcentaje
            Return sueldoTotal
        End If

    End Function

    Public Function ToString() As String

        Return "Empleado:" & propNom & " " & propApe & " -Tipo:" & propTipo & " -Sueldo mensual:" & propSueldoMens & " -Direccion:" & propDir & " -Telefonos:" & propTel1 & propTel2

    End Function


    Public Function TipoDeEmpleado() As String

        Return propTipo

    End Function

End Class
