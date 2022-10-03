<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NumbersGrid
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
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r1 = New System.Windows.Forms.Label()
        Me.r2 = New System.Windows.Forms.Label()
        Me.r3 = New System.Windows.Forms.Label()
        Me.r4 = New System.Windows.Forms.Label()
        Me.r5 = New System.Windows.Forms.Label()
        Me.c1 = New System.Windows.Forms.Label()
        Me.c2 = New System.Windows.Forms.Label()
        Me.c3 = New System.Windows.Forms.Label()
        Me.addBtn = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.N1, Me.N2, Me.N3})
        Me.DataGrid.Location = New System.Drawing.Point(252, 118)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.Size = New System.Drawing.Size(222, 200)
        Me.DataGrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca números positivos:"
        '
        'N1
        '
        Me.N1.HeaderText = "N1"
        Me.N1.Name = "N1"
        Me.N1.ReadOnly = True
        '
        'N2
        '
        Me.N2.HeaderText = "N2"
        Me.N2.Name = "N2"
        Me.N2.ReadOnly = True
        '
        'N3
        '
        Me.N3.HeaderText = "N3"
        Me.N3.Name = "N3"
        Me.N3.ReadOnly = True
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1.Location = New System.Drawing.Point(495, 142)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(16, 16)
        Me.r1.TabIndex = 2
        Me.r1.Text = "0"
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2.Location = New System.Drawing.Point(495, 167)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(16, 16)
        Me.r2.TabIndex = 3
        Me.r2.Text = "0"
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3.Location = New System.Drawing.Point(495, 193)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(16, 16)
        Me.r3.TabIndex = 4
        Me.r3.Text = "0"
        '
        'r4
        '
        Me.r4.AutoSize = True
        Me.r4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r4.Location = New System.Drawing.Point(495, 219)
        Me.r4.Name = "r4"
        Me.r4.Size = New System.Drawing.Size(16, 16)
        Me.r4.TabIndex = 5
        Me.r4.Text = "0"
        '
        'r5
        '
        Me.r5.AutoSize = True
        Me.r5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r5.Location = New System.Drawing.Point(495, 245)
        Me.r5.Name = "r5"
        Me.r5.Size = New System.Drawing.Size(16, 16)
        Me.r5.TabIndex = 6
        Me.r5.Text = "0"
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(315, 348)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(16, 16)
        Me.c1.TabIndex = 7
        Me.c1.Text = "0"
        '
        'c2
        '
        Me.c2.AutoSize = True
        Me.c2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(381, 348)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(16, 16)
        Me.c2.TabIndex = 8
        Me.c2.Text = "0"
        '
        'c3
        '
        Me.c3.AutoSize = True
        Me.c3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.Location = New System.Drawing.Point(442, 348)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(16, 16)
        Me.c3.TabIndex = 9
        Me.c3.Text = "0"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(318, 89)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(127, 23)
        Me.addBtn.TabIndex = 10
        Me.addBtn.Text = "Añadir valores"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'NumbersGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.r5)
        Me.Controls.Add(Me.r4)
        Me.Controls.Add(Me.r3)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "NumbersGrid"
        Me.Text = "NumbersGrid"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents N1 As DataGridViewTextBoxColumn
    Friend WithEvents N2 As DataGridViewTextBoxColumn
    Friend WithEvents N3 As DataGridViewTextBoxColumn
    Friend WithEvents r1 As Label
    Friend WithEvents r2 As Label
    Friend WithEvents r3 As Label
    Friend WithEvents r4 As Label
    Friend WithEvents r5 As Label
    Friend WithEvents c1 As Label
    Friend WithEvents c2 As Label
    Friend WithEvents c3 As Label
    Friend WithEvents addBtn As Button
End Class
