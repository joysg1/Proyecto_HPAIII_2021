Imports System.Data.SqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 1 To 2
            MsgBox("Cargando por favor espere...")
        Next

        gbLectura.Enabled = False
        gbModificar.Enabled = False
        gbAgregar.Enabled = False
        gbEliminar.Enabled = False

    End Sub

    Private Sub cbOpcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOpcion.SelectedIndexChanged
        CambioOpcion()
    End Sub

    Sub CambioOpcion()
        If (cbOpcion.SelectedIndex = 0) Then
            gbLectura.Enabled = True
            gbLectura.BackColor = Color.Aquamarine
            gbModificar.Enabled = False
            gbModificar.BackColor = Color.LightGray
            gbAgregar.Enabled = False
            gbAgregar.BackColor = Color.LightGray
            gbEliminar.Enabled = False
            gbEliminar.BackColor = Color.LightGray
            leer()
        ElseIf (cbOpcion.SelectedIndex = 1) Then
            gbModificar.Enabled = True
            gbModificar.BackColor = Color.Aquamarine
            gbLectura.Enabled = False
            gbLectura.BackColor = Color.LightGray
            gbAgregar.Enabled = False
            gbAgregar.BackColor = Color.LightGray
            gbEliminar.Enabled = False
            gbEliminar.BackColor = Color.LightGray
        ElseIf (cbOpcion.SelectedIndex = 2) Then
            gbAgregar.Enabled = True
            gbAgregar.BackColor = Color.Aquamarine
            gbLectura.Enabled = False
            gbLectura.BackColor = Color.LightGray
            gbModificar.Enabled = False
            gbModificar.BackColor = Color.LightGray
            gbEliminar.Enabled = False
            gbEliminar.BackColor = Color.LightGray
        ElseIf (cbOpcion.SelectedIndex = 3) Then
            gbEliminar.Enabled = True
            gbEliminar.BackColor = Color.Aquamarine
            gbLectura.Enabled = False
            gbLectura.BackColor = Color.LightGray
            gbModificar.Enabled = False
            gbModificar.BackColor = Color.LightGray
            gbAgregar.Enabled = False
            gbAgregar.BackColor = Color.LightGray

        End If
    End Sub

    Sub leer()

        Dim con As New SqlConnection(My.Settings.Conectar)
        Dim sql As String = "Select *  from jugador"
        Dim comando As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(comando)
            Dim ds As New DataSet
            da.Fill(ds, "jugador")

            Me.dgDatos.DataSource = ds.Tables("jugador")
            MsgBox("Tarea completada")

        Catch ex As Exception
            MsgBox("Error de ejecucion")

        End Try


    End Sub


    Sub agregar()
        Dim numero, edad, club, funda As Integer
        Dim nombre, apellido, posicion As String

        numero = CInt(numSelec.Value)
        edad = CInt(edadSelec.Value)

        nombre = tbNombre.Text
        apellido = tbApellido.Text
        posicion = tbPosicion.Text
        club = Val(tbClub.Text)
        funda = Val(tbFunda.Text)

        If (nombre = "" Or apellido = "" Or posicion = "" Or funda < 300 Or funda > 315 Or club < 1700 Or club > 1715) Then

            MsgBox("Favor verifique los datos ingresados")

        Else
            Dim con As New SqlConnection(My.Settings.Conectar)
            con.Open()

            Try
                Dim sql As String = "Insert into jugador (numero, nombre, apellido, edad, posicion, id_club, id_funda) Values ('" & numero & "', '" & nombre & "', '" & apellido & "' , '" & edad & "', '" & posicion & "', '" & club & "', '" & funda & "')"
                Dim comando As New SqlCommand(sql, con)

                comando.ExecuteNonQuery()
                con.Close()
                MsgBox("Tarea completada con exito")

                limpiar()
            Catch ex As Exception
                con.Close()
                MsgBox("Error de ejecucion")

            End Try



        End If







    End Sub

    Private Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        agregar()
    End Sub


    Sub limpiar()
        tbNombre.Clear()
        tbApellido.Clear()
        tbClub.Clear()
        tbFunda.Clear()
        tbPosicion.Clear()

        MtbNombre.Clear()
        MtbApellido.Clear()
        MtbClub.Clear()
        MtbFunda.Clear()
        MtbPosicion.Clear()
    End Sub


    Sub Eliminar()

        Dim numero As Integer

        numero = CInt(numeroEliminarSelec.Value)

        Dim con As New SqlConnection(My.Settings.Conectar)
        con.Open()


        Dim sql0 As String = "select numero from jugador where numero = ('" & numero & "')"

        Dim comando0 As New SqlCommand(sql0, con)

        Try
            comando0.ExecuteNonQuery()
            Dim Sql As String = "delete from jugador where numero = ('" & numero & "')"
            Dim comando As New SqlCommand(sql, con)
            comando.ExecuteNonQuery()
            con.Close()
            MsgBox("Tarea completada con exito")
        Catch ex As Exception
            MsgBox("Error de ejecucion")
            con.Close()

        End Try















    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Eliminar()

    End Sub

    Sub Modificar()
        Dim numero, edad, club, funda As Integer
        Dim nombre, apellido, posicion As String

        numero = CInt(MnumSelec.Value)
        edad = CInt(MedadSelec.Value)

        nombre = MtbNombre.Text
        apellido = MtbApellido.Text
        posicion = MtbPosicion.Text
        club = Val(MtbClub.Text)
        funda = Val(MtbFunda.Text)

        If (nombre = "" Or apellido = "" Or posicion = "" Or funda < 300 Or funda > 315 Or club < 1700 Or club > 1715) Then

            MsgBox("Favor verifique los datos ingresados")

        Else
            Dim con As New SqlConnection(My.Settings.Conectar)
            con.Open()

            Try


                Dim sqlN As String = "update jugador set nombre = '" & nombre & "'  where numero = '" & numero & "'"
                Dim comandoN As New SqlCommand(sqlN, con)
                comandoN.ExecuteNonQuery()

                Dim sqlA As String = "update jugador set apellido =  '" & apellido & "'  where numero = '" & numero & "'"
                Dim comandoA As New SqlCommand(sqlA, con)
                comandoA.ExecuteNonQuery()

                Dim sqlE As String = "update jugador set edad = '" & edad & "'  where numero = '" & numero & "'"
                Dim comandoE As New SqlCommand(sqlE, con)
                comandoE.ExecuteNonQuery()

                Dim sqlP As String = "update jugador set posicion = '" & posicion & "'  where numero = '" & numero & "'"
                Dim comandoP As New SqlCommand(sqlP, con)
                comandoP.ExecuteNonQuery()

                Dim sqlC As String = "update jugador set id_club = '" & club & "'  where numero = '" & numero & "'"
                Dim comandoC As New SqlCommand(sqlC, con)
                comandoC.ExecuteNonQuery()

                Dim sqlF As String = "update jugador set id_funda =  '" & funda & "'  where numero = '" & numero & "'"
                Dim comandoF As New SqlCommand(sqlF, con)
                comandoF.ExecuteNonQuery()

                con.Close()
                MsgBox("Tarea completada con exito")

                limpiar()

            Catch ex As Exception
                MsgBox("Error de ejecucion")
                con.Close()
            End Try








        End If

    End Sub

    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Modificar()

    End Sub

    Private Sub bModificar_MouseHover(sender As Object, e As EventArgs) Handles bModificar.MouseHover
        bModificar.BackColor = Color.Aquamarine
    End Sub

    Private Sub bModificar_MouseLeave(sender As Object, e As EventArgs) Handles bModificar.MouseLeave
        bModificar.BackColor = Color.LightGreen
    End Sub

    Private Sub bAgregar_MouseHover(sender As Object, e As EventArgs) Handles bAgregar.MouseHover
        bAgregar.BackColor = Color.Aquamarine
    End Sub

    Private Sub bAgregar_MouseLeave(sender As Object, e As EventArgs) Handles bAgregar.MouseLeave
        bAgregar.BackColor = Color.LightGreen
    End Sub

    Private Sub bEliminar_MouseHover(sender As Object, e As EventArgs) Handles bEliminar.MouseHover
        bEliminar.BackColor = Color.Aquamarine
    End Sub

    Private Sub bEliminar_MouseLeave(sender As Object, e As EventArgs) Handles bEliminar.MouseLeave
        bEliminar.BackColor = Color.LightGreen
    End Sub
End Class