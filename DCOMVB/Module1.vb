Imports System.Runtime.InteropServices

Namespace DCOMVB
    <ComVisible(True)>
    Public Class ServidorDCOM
        <ComVisible(True)>
        Public Function ObtenerSaludo(nombre As String) As String
            Return $"Hola, {nombre}!"
        End Function
    End Class
End Namespace

