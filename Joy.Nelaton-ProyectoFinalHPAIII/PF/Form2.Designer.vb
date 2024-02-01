<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbOpcion = New System.Windows.Forms.ComboBox()
        Me.gbLectura = New System.Windows.Forms.GroupBox()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.gbModificar = New System.Windows.Forms.GroupBox()
        Me.MtbFunda = New System.Windows.Forms.TextBox()
        Me.MtbClub = New System.Windows.Forms.TextBox()
        Me.MlbIDfunda = New System.Windows.Forms.Label()
        Me.MlbIDclub = New System.Windows.Forms.Label()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.MlbPosicion = New System.Windows.Forms.Label()
        Me.MlbEdad = New System.Windows.Forms.Label()
        Me.MlbApellido = New System.Windows.Forms.Label()
        Me.MlbNom = New System.Windows.Forms.Label()
        Me.MlbNum = New System.Windows.Forms.Label()
        Me.MtbPosicion = New System.Windows.Forms.TextBox()
        Me.MedadSelec = New System.Windows.Forms.NumericUpDown()
        Me.MtbApellido = New System.Windows.Forms.TextBox()
        Me.MnumSelec = New System.Windows.Forms.NumericUpDown()
        Me.MtbNombre = New System.Windows.Forms.TextBox()
        Me.gbAgregar = New System.Windows.Forms.GroupBox()
        Me.tbFunda = New System.Windows.Forms.TextBox()
        Me.tbClub = New System.Windows.Forms.TextBox()
        Me.lbIDfunda = New System.Windows.Forms.Label()
        Me.lbIDclub = New System.Windows.Forms.Label()
        Me.bAgregar = New System.Windows.Forms.Button()
        Me.lbPosicion = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbApellido = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbNum = New System.Windows.Forms.Label()
        Me.tbPosicion = New System.Windows.Forms.TextBox()
        Me.edadSelec = New System.Windows.Forms.NumericUpDown()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.numSelec = New System.Windows.Forms.NumericUpDown()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.gbEliminar = New System.Windows.Forms.GroupBox()
        Me.bEliminar = New System.Windows.Forms.Button()
        Me.lbNumEliminar = New System.Windows.Forms.Label()
        Me.numeroEliminarSelec = New System.Windows.Forms.NumericUpDown()
        Me.gbLectura.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbModificar.SuspendLayout()
        CType(Me.MedadSelec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MnumSelec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAgregar.SuspendLayout()
        CType(Me.edadSelec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSelec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEliminar.SuspendLayout()
        CType(Me.numeroEliminarSelec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbOpcion
        '
        Me.cbOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOpcion.FormattingEnabled = True
        Me.cbOpcion.Items.AddRange(New Object() {"Leer datos", "Modificar datos", "Agregar datos ", "Eliminar datos"})
        Me.cbOpcion.Location = New System.Drawing.Point(240, 22)
        Me.cbOpcion.Name = "cbOpcion"
        Me.cbOpcion.Size = New System.Drawing.Size(173, 26)
        Me.cbOpcion.TabIndex = 0
        Me.cbOpcion.Text = "Seleccione"
        '
        'gbLectura
        '
        Me.gbLectura.Controls.Add(Me.dgDatos)
        Me.gbLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLectura.Location = New System.Drawing.Point(24, 88)
        Me.gbLectura.Name = "gbLectura"
        Me.gbLectura.Size = New System.Drawing.Size(609, 213)
        Me.gbLectura.TabIndex = 1
        Me.gbLectura.TabStop = False
        Me.gbLectura.Text = "LECTURA DE DATOS"
        '
        'dgDatos
        '
        Me.dgDatos.AllowUserToAddRows = False
        Me.dgDatos.AllowUserToDeleteRows = False
        Me.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(7, 31)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.ReadOnly = True
        Me.dgDatos.RowTemplate.Height = 24
        Me.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDatos.Size = New System.Drawing.Size(594, 165)
        Me.dgDatos.TabIndex = 0
        '
        'gbModificar
        '
        Me.gbModificar.Controls.Add(Me.MtbFunda)
        Me.gbModificar.Controls.Add(Me.MtbClub)
        Me.gbModificar.Controls.Add(Me.MlbIDfunda)
        Me.gbModificar.Controls.Add(Me.MlbIDclub)
        Me.gbModificar.Controls.Add(Me.bModificar)
        Me.gbModificar.Controls.Add(Me.MlbPosicion)
        Me.gbModificar.Controls.Add(Me.MlbEdad)
        Me.gbModificar.Controls.Add(Me.MlbApellido)
        Me.gbModificar.Controls.Add(Me.MlbNom)
        Me.gbModificar.Controls.Add(Me.MlbNum)
        Me.gbModificar.Controls.Add(Me.MtbPosicion)
        Me.gbModificar.Controls.Add(Me.MedadSelec)
        Me.gbModificar.Controls.Add(Me.MtbApellido)
        Me.gbModificar.Controls.Add(Me.MnumSelec)
        Me.gbModificar.Controls.Add(Me.MtbNombre)
        Me.gbModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbModificar.Location = New System.Drawing.Point(24, 341)
        Me.gbModificar.Name = "gbModificar"
        Me.gbModificar.Size = New System.Drawing.Size(230, 373)
        Me.gbModificar.TabIndex = 2
        Me.gbModificar.TabStop = False
        Me.gbModificar.Text = "MODIFICAR DATOS"
        '
        'MtbFunda
        '
        Me.MtbFunda.Location = New System.Drawing.Point(92, 259)
        Me.MtbFunda.Name = "MtbFunda"
        Me.MtbFunda.Size = New System.Drawing.Size(100, 22)
        Me.MtbFunda.TabIndex = 29
        '
        'MtbClub
        '
        Me.MtbClub.Location = New System.Drawing.Point(92, 225)
        Me.MtbClub.Name = "MtbClub"
        Me.MtbClub.Size = New System.Drawing.Size(100, 22)
        Me.MtbClub.TabIndex = 28
        '
        'MlbIDfunda
        '
        Me.MlbIDfunda.AutoSize = True
        Me.MlbIDfunda.Location = New System.Drawing.Point(20, 264)
        Me.MlbIDfunda.Name = "MlbIDfunda"
        Me.MlbIDfunda.Size = New System.Drawing.Size(69, 17)
        Me.MlbIDfunda.TabIndex = 27
        Me.MlbIDfunda.Text = "ID Fund."
        '
        'MlbIDclub
        '
        Me.MlbIDclub.AutoSize = True
        Me.MlbIDclub.Location = New System.Drawing.Point(19, 228)
        Me.MlbIDclub.Name = "MlbIDclub"
        Me.MlbIDclub.Size = New System.Drawing.Size(58, 17)
        Me.MlbIDclub.TabIndex = 26
        Me.MlbIDclub.Text = "ID club"
        '
        'bModificar
        '
        Me.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModificar.Location = New System.Drawing.Point(44, 316)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(148, 29)
        Me.bModificar.TabIndex = 25
        Me.bModificar.Text = "MODIFICAR"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'MlbPosicion
        '
        Me.MlbPosicion.AutoSize = True
        Me.MlbPosicion.Location = New System.Drawing.Point(19, 185)
        Me.MlbPosicion.Name = "MlbPosicion"
        Me.MlbPosicion.Size = New System.Drawing.Size(69, 17)
        Me.MlbPosicion.TabIndex = 24
        Me.MlbPosicion.Text = "Posicion"
        '
        'MlbEdad
        '
        Me.MlbEdad.AutoSize = True
        Me.MlbEdad.Location = New System.Drawing.Point(19, 150)
        Me.MlbEdad.Name = "MlbEdad"
        Me.MlbEdad.Size = New System.Drawing.Size(45, 17)
        Me.MlbEdad.TabIndex = 23
        Me.MlbEdad.Text = "Edad"
        '
        'MlbApellido
        '
        Me.MlbApellido.AutoSize = True
        Me.MlbApellido.Location = New System.Drawing.Point(19, 109)
        Me.MlbApellido.Name = "MlbApellido"
        Me.MlbApellido.Size = New System.Drawing.Size(66, 17)
        Me.MlbApellido.TabIndex = 22
        Me.MlbApellido.Text = "Apellido"
        '
        'MlbNom
        '
        Me.MlbNom.AutoSize = True
        Me.MlbNom.Location = New System.Drawing.Point(19, 70)
        Me.MlbNom.Name = "MlbNom"
        Me.MlbNom.Size = New System.Drawing.Size(64, 17)
        Me.MlbNom.TabIndex = 21
        Me.MlbNom.Text = "Nombre"
        '
        'MlbNum
        '
        Me.MlbNum.AutoSize = True
        Me.MlbNum.Location = New System.Drawing.Point(19, 33)
        Me.MlbNum.Name = "MlbNum"
        Me.MlbNum.Size = New System.Drawing.Size(64, 17)
        Me.MlbNum.TabIndex = 20
        Me.MlbNum.Text = "Numero"
        '
        'MtbPosicion
        '
        Me.MtbPosicion.Location = New System.Drawing.Point(92, 182)
        Me.MtbPosicion.Name = "MtbPosicion"
        Me.MtbPosicion.Size = New System.Drawing.Size(100, 22)
        Me.MtbPosicion.TabIndex = 19
        '
        'MedadSelec
        '
        Me.MedadSelec.Location = New System.Drawing.Point(92, 145)
        Me.MedadSelec.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.MedadSelec.Minimum = New Decimal(New Integer() {17, 0, 0, 0})
        Me.MedadSelec.Name = "MedadSelec"
        Me.MedadSelec.Size = New System.Drawing.Size(120, 22)
        Me.MedadSelec.TabIndex = 18
        Me.MedadSelec.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'MtbApellido
        '
        Me.MtbApellido.Location = New System.Drawing.Point(92, 104)
        Me.MtbApellido.Name = "MtbApellido"
        Me.MtbApellido.Size = New System.Drawing.Size(100, 22)
        Me.MtbApellido.TabIndex = 17
        '
        'MnumSelec
        '
        Me.MnumSelec.Location = New System.Drawing.Point(92, 28)
        Me.MnumSelec.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.MnumSelec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.MnumSelec.Name = "MnumSelec"
        Me.MnumSelec.Size = New System.Drawing.Size(120, 22)
        Me.MnumSelec.TabIndex = 16
        Me.MnumSelec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MtbNombre
        '
        Me.MtbNombre.Location = New System.Drawing.Point(92, 65)
        Me.MtbNombre.Name = "MtbNombre"
        Me.MtbNombre.Size = New System.Drawing.Size(100, 22)
        Me.MtbNombre.TabIndex = 15
        '
        'gbAgregar
        '
        Me.gbAgregar.Controls.Add(Me.tbFunda)
        Me.gbAgregar.Controls.Add(Me.tbClub)
        Me.gbAgregar.Controls.Add(Me.lbIDfunda)
        Me.gbAgregar.Controls.Add(Me.lbIDclub)
        Me.gbAgregar.Controls.Add(Me.bAgregar)
        Me.gbAgregar.Controls.Add(Me.lbPosicion)
        Me.gbAgregar.Controls.Add(Me.lbEdad)
        Me.gbAgregar.Controls.Add(Me.lbApellido)
        Me.gbAgregar.Controls.Add(Me.lbNombre)
        Me.gbAgregar.Controls.Add(Me.lbNum)
        Me.gbAgregar.Controls.Add(Me.tbPosicion)
        Me.gbAgregar.Controls.Add(Me.edadSelec)
        Me.gbAgregar.Controls.Add(Me.tbApellido)
        Me.gbAgregar.Controls.Add(Me.numSelec)
        Me.gbAgregar.Controls.Add(Me.tbNombre)
        Me.gbAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAgregar.Location = New System.Drawing.Point(273, 341)
        Me.gbAgregar.Name = "gbAgregar"
        Me.gbAgregar.Size = New System.Drawing.Size(217, 373)
        Me.gbAgregar.TabIndex = 3
        Me.gbAgregar.TabStop = False
        Me.gbAgregar.Text = "AGREGAR DATOS"
        '
        'tbFunda
        '
        Me.tbFunda.Location = New System.Drawing.Point(91, 262)
        Me.tbFunda.Name = "tbFunda"
        Me.tbFunda.Size = New System.Drawing.Size(100, 22)
        Me.tbFunda.TabIndex = 14
        '
        'tbClub
        '
        Me.tbClub.Location = New System.Drawing.Point(91, 228)
        Me.tbClub.Name = "tbClub"
        Me.tbClub.Size = New System.Drawing.Size(100, 22)
        Me.tbClub.TabIndex = 13
        '
        'lbIDfunda
        '
        Me.lbIDfunda.AutoSize = True
        Me.lbIDfunda.Location = New System.Drawing.Point(19, 267)
        Me.lbIDfunda.Name = "lbIDfunda"
        Me.lbIDfunda.Size = New System.Drawing.Size(69, 17)
        Me.lbIDfunda.TabIndex = 12
        Me.lbIDfunda.Text = "ID Fund."
        '
        'lbIDclub
        '
        Me.lbIDclub.AutoSize = True
        Me.lbIDclub.Location = New System.Drawing.Point(18, 231)
        Me.lbIDclub.Name = "lbIDclub"
        Me.lbIDclub.Size = New System.Drawing.Size(58, 17)
        Me.lbIDclub.TabIndex = 11
        Me.lbIDclub.Text = "ID club"
        '
        'bAgregar
        '
        Me.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregar.Location = New System.Drawing.Point(43, 319)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(148, 29)
        Me.bAgregar.TabIndex = 10
        Me.bAgregar.Text = "AGREGAR"
        Me.bAgregar.UseVisualStyleBackColor = True
        '
        'lbPosicion
        '
        Me.lbPosicion.AutoSize = True
        Me.lbPosicion.Location = New System.Drawing.Point(18, 188)
        Me.lbPosicion.Name = "lbPosicion"
        Me.lbPosicion.Size = New System.Drawing.Size(69, 17)
        Me.lbPosicion.TabIndex = 9
        Me.lbPosicion.Text = "Posicion"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Location = New System.Drawing.Point(18, 153)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(45, 17)
        Me.lbEdad.TabIndex = 8
        Me.lbEdad.Text = "Edad"
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.Location = New System.Drawing.Point(18, 112)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(66, 17)
        Me.lbApellido.TabIndex = 7
        Me.lbApellido.Text = "Apellido"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(18, 73)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(64, 17)
        Me.lbNombre.TabIndex = 6
        Me.lbNombre.Text = "Nombre"
        '
        'lbNum
        '
        Me.lbNum.AutoSize = True
        Me.lbNum.Location = New System.Drawing.Point(18, 36)
        Me.lbNum.Name = "lbNum"
        Me.lbNum.Size = New System.Drawing.Size(64, 17)
        Me.lbNum.TabIndex = 5
        Me.lbNum.Text = "Numero"
        '
        'tbPosicion
        '
        Me.tbPosicion.Location = New System.Drawing.Point(91, 185)
        Me.tbPosicion.Name = "tbPosicion"
        Me.tbPosicion.Size = New System.Drawing.Size(100, 22)
        Me.tbPosicion.TabIndex = 4
        '
        'edadSelec
        '
        Me.edadSelec.Location = New System.Drawing.Point(91, 148)
        Me.edadSelec.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.edadSelec.Minimum = New Decimal(New Integer() {17, 0, 0, 0})
        Me.edadSelec.Name = "edadSelec"
        Me.edadSelec.Size = New System.Drawing.Size(120, 22)
        Me.edadSelec.TabIndex = 3
        Me.edadSelec.Value = New Decimal(New Integer() {17, 0, 0, 0})
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(91, 107)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(100, 22)
        Me.tbApellido.TabIndex = 2
        '
        'numSelec
        '
        Me.numSelec.Location = New System.Drawing.Point(91, 31)
        Me.numSelec.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numSelec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSelec.Name = "numSelec"
        Me.numSelec.Size = New System.Drawing.Size(120, 22)
        Me.numSelec.TabIndex = 1
        Me.numSelec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(91, 68)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 22)
        Me.tbNombre.TabIndex = 0
        '
        'gbEliminar
        '
        Me.gbEliminar.Controls.Add(Me.bEliminar)
        Me.gbEliminar.Controls.Add(Me.lbNumEliminar)
        Me.gbEliminar.Controls.Add(Me.numeroEliminarSelec)
        Me.gbEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEliminar.Location = New System.Drawing.Point(512, 341)
        Me.gbEliminar.Name = "gbEliminar"
        Me.gbEliminar.Size = New System.Drawing.Size(113, 170)
        Me.gbEliminar.TabIndex = 4
        Me.gbEliminar.TabStop = False
        Me.gbEliminar.Text = "ELIMINAR DATOS"
        '
        'bEliminar
        '
        Me.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEliminar.Location = New System.Drawing.Point(9, 124)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(98, 29)
        Me.bEliminar.TabIndex = 11
        Me.bEliminar.Text = "ELIMINAR"
        Me.bEliminar.UseVisualStyleBackColor = True
        '
        'lbNumEliminar
        '
        Me.lbNumEliminar.AutoSize = True
        Me.lbNumEliminar.Location = New System.Drawing.Point(6, 51)
        Me.lbNumEliminar.Name = "lbNumEliminar"
        Me.lbNumEliminar.Size = New System.Drawing.Size(104, 17)
        Me.lbNumEliminar.TabIndex = 6
        Me.lbNumEliminar.Text = "# de Jugador"
        '
        'numeroEliminarSelec
        '
        Me.numeroEliminarSelec.Location = New System.Drawing.Point(6, 71)
        Me.numeroEliminarSelec.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.numeroEliminarSelec.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numeroEliminarSelec.Name = "numeroEliminarSelec"
        Me.numeroEliminarSelec.Size = New System.Drawing.Size(90, 22)
        Me.numeroEliminarSelec.TabIndex = 0
        Me.numeroEliminarSelec.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(637, 726)
        Me.Controls.Add(Me.gbEliminar)
        Me.Controls.Add(Me.gbAgregar)
        Me.Controls.Add(Me.gbModificar)
        Me.Controls.Add(Me.gbLectura)
        Me.Controls.Add(Me.cbOpcion)
        Me.Name = "Form2"
        Me.Text = "PLANTILLA"
        Me.gbLectura.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbModificar.ResumeLayout(False)
        Me.gbModificar.PerformLayout()
        CType(Me.MedadSelec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MnumSelec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAgregar.ResumeLayout(False)
        Me.gbAgregar.PerformLayout()
        CType(Me.edadSelec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSelec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEliminar.ResumeLayout(False)
        Me.gbEliminar.PerformLayout()
        CType(Me.numeroEliminarSelec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbOpcion As ComboBox
    Friend WithEvents gbLectura As GroupBox
    Friend WithEvents gbModificar As GroupBox
    Friend WithEvents gbAgregar As GroupBox
    Friend WithEvents gbEliminar As GroupBox
    Friend WithEvents dgDatos As DataGridView
    Friend WithEvents lbPosicion As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbApellido As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbNum As Label
    Friend WithEvents tbPosicion As TextBox
    Friend WithEvents edadSelec As NumericUpDown
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents numSelec As NumericUpDown
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents bAgregar As Button
    Friend WithEvents tbFunda As TextBox
    Friend WithEvents tbClub As TextBox
    Friend WithEvents lbIDfunda As Label
    Friend WithEvents lbIDclub As Label
    Friend WithEvents bEliminar As Button
    Friend WithEvents lbNumEliminar As Label
    Friend WithEvents numeroEliminarSelec As NumericUpDown
    Friend WithEvents MtbFunda As TextBox
    Friend WithEvents MtbClub As TextBox
    Friend WithEvents MlbIDfunda As Label
    Friend WithEvents MlbIDclub As Label
    Friend WithEvents bModificar As Button
    Friend WithEvents MlbPosicion As Label
    Friend WithEvents MlbEdad As Label
    Friend WithEvents MlbApellido As Label
    Friend WithEvents MlbNom As Label
    Friend WithEvents MlbNum As Label
    Friend WithEvents MtbPosicion As TextBox
    Friend WithEvents MedadSelec As NumericUpDown
    Friend WithEvents MtbApellido As TextBox
    Friend WithEvents MnumSelec As NumericUpDown
    Friend WithEvents MtbNombre As TextBox
End Class
