<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        NumericUpDown1 = New NumericUpDown()
        Label6 = New Label()
        Label7 = New Label()
        txtnama = New TextBox()
        Muka = New TextBox()
        Mobil = New TextBox()
        Label8 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(229, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 41)
        Label1.TabIndex = 0
        Label1.Text = "Aplikasi Credit"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(66, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 23)
        Label2.TabIndex = 1
        Label2.Text = "Nama Nasabah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(130, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 23)
        Label3.TabIndex = 2
        Label3.Text = "Usia"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(88, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 23)
        Label4.TabIndex = 3
        Label4.Text = "Lama Credit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(20, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 23)
        Label5.TabIndex = 4
        Label5.Text = "Tanggal Mulai Pinjaman"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3"})
        ComboBox1.Location = New Point(229, 161)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(352, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(229, 220)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(352, 27)
        DateTimePicker1.TabIndex = 9
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(229, 113)
        NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(102, 27)
        NumericUpDown1.TabIndex = 10
        NumericUpDown1.Value = New Decimal(New Integer() {25, 0, 0, 0})
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(88, 271)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 23)
        Label6.TabIndex = 11
        Label6.Text = "Harga Mobil"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(97, 322)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 23)
        Label7.TabIndex = 12
        Label7.Text = "Uang Muka"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(229, 59)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(352, 27)
        txtnama.TabIndex = 13
        ' 
        ' Muka
        ' 
        Muka.Location = New Point(229, 321)
        Muka.Name = "Muka"
        Muka.Size = New Size(352, 27)
        Muka.TabIndex = 14
        ' 
        ' Mobil
        ' 
        Mobil.Location = New Point(229, 270)
        Mobil.Name = "Mobil"
        Mobil.Size = New Size(352, 27)
        Mobil.TabIndex = 15
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(77, 368)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 23)
        Label8.TabIndex = 16
        Label8.Text = "Jenis Kelamin"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(294, 368)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(76, 24)
        RadioButton1.TabIndex = 17
        RadioButton1.TabStop = True
        RadioButton1.Text = "Wanita"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(214, 368)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(55, 24)
        RadioButton2.TabIndex = 18
        RadioButton2.TabStop = True
        RadioButton2.Text = "Pria"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(214, 414)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(129, 24)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = "Nasabah Lama"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(214, 456)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 20
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 531)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label8)
        Controls.Add(Mobil)
        Controls.Add(Muka)
        Controls.Add(txtnama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(NumericUpDown1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Muka As TextBox
    Friend WithEvents Mobil As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
End Class
