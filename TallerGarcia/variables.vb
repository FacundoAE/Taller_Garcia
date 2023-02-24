Module variables
    'Bandera para indicar el tipo de acción que se ejecuta sobre el boton CONFIRMAR (ALTA - MODIFICACION - BAJA)
    Public flag_abm As Integer = 0 '1 ALTA - 2 MODIFICACION - 3 BAJA

    'Variable para traer la FK en la carga de registros
    Public wrfm As Integer = 0 ' 1 Operarios Especialidad, 2 Tareas Especialidad

    'Reportes
    Public nroPatente As String
    Public nroPropietario As String

    'Gastos Reportes
    Public gPropietario As String
    Public gFechaUno As String
    Public gFechaDos As String
End Module
