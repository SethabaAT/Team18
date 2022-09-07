<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironmental
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.grdYearsEnviro = New UJGrid.UJGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grdDetails = New UJGrid.UJGrid()
        Me.btnShowDetails = New System.Windows.Forms.Button()
        Me.btnTotalPopulation = New System.Windows.Forms.Button()
        Me.btnDensity = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtnYears = New System.Windows.Forms.TextBox()
        Me.txtEnviroCount = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(270, 16)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(129, 33)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Input Data"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'grdYearsEnviro
        '
        Me.grdYearsEnviro.FixedCols = 1
        Me.grdYearsEnviro.FixedRows = 1
        Me.grdYearsEnviro.Location = New System.Drawing.Point(13, 222)
        Me.grdYearsEnviro.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grdYearsEnviro.Name = "grdYearsEnviro"
        Me.grdYearsEnviro.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdYearsEnviro.Size = New System.Drawing.Size(424, 184)
        Me.grdYearsEnviro.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.grdDetails)
        Me.Panel2.Controls.Add(Me.btnShowDetails)
        Me.Panel2.Location = New System.Drawing.Point(443, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 393)
        Me.Panel2.TabIndex = 2
        '
        'grdDetails
        '
        Me.grdDetails.FixedCols = 1
        Me.grdDetails.FixedRows = 1
        Me.grdDetails.Location = New System.Drawing.Point(5, 51)
        Me.grdDetails.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.grdDetails.Name = "grdDetails"
        Me.grdDetails.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDetails.Size = New System.Drawing.Size(272, 333)
        Me.grdDetails.TabIndex = 3
        '
        'btnShowDetails
        '
        Me.btnShowDetails.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnShowDetails.Location = New System.Drawing.Point(79, 9)
        Me.btnShowDetails.Name = "btnShowDetails"
        Me.btnShowDetails.Size = New System.Drawing.Size(128, 34)
        Me.btnShowDetails.TabIndex = 0
        Me.btnShowDetails.Text = "Show Details"
        Me.btnShowDetails.UseVisualStyleBackColor = False
        '
        'btnTotalPopulation
        '
        Me.btnTotalPopulation.Location = New System.Drawing.Point(270, 55)
        Me.btnTotalPopulation.Name = "btnTotalPopulation"
        Me.btnTotalPopulation.Size = New System.Drawing.Size(129, 33)
        Me.btnTotalPopulation.TabIndex = 0
        Me.btnTotalPopulation.Text = "Total Population"
        Me.btnTotalPopulation.UseVisualStyleBackColor = True
        '
        'btnDensity
        '
        Me.btnDensity.Location = New System.Drawing.Point(270, 95)
        Me.btnDensity.Name = "btnDensity"
        Me.btnDensity.Size = New System.Drawing.Size(129, 33)
        Me.btnDensity.TabIndex = 0
        Me.btnDensity.Text = "Density"
        Me.btnDensity.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnStart)
        Me.Panel3.Controls.Add(Me.txtnYears)
        Me.Panel3.Controls.Add(Me.txtEnviroCount)
        Me.Panel3.Location = New System.Drawing.Point(13, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 163)
        Me.Panel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Environment  Count"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Years"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStart.Location = New System.Drawing.Point(43, 111)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 33)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Application"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txtnYears
        '
        Me.txtnYears.Location = New System.Drawing.Point(157, 66)
        Me.txtnYears.Name = "txtnYears"
        Me.txtnYears.Size = New System.Drawing.Size(49, 25)
        Me.txtnYears.TabIndex = 1
        '
        'txtEnviroCount
        '
        Me.txtEnviroCount.Location = New System.Drawing.Point(157, 36)
        Me.txtEnviroCount.Name = "txtEnviroCount"
        Me.txtEnviroCount.Size = New System.Drawing.Size(50, 25)
        Me.txtEnviroCount.TabIndex = 1
        '
        'frmEnvironmental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 428)
        Me.Controls.Add(Me.grdYearsEnviro)
        Me.Controls.Add(Me.btnDensity)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnTotalPopulation)
        Me.Controls.Add(Me.btnInput)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmEnvironmental"
        Me.Text = "Environmental Sustainability"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents grdYearsEnviro As UJGrid.UJGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grdDetails As UJGrid.UJGrid
    Friend WithEvents btnShowDetails As Button
    Friend WithEvents btnTotalPopulation As Button
    Friend WithEvents btnDensity As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents txtnYears As TextBox
    Friend WithEvents txtEnviroCount As TextBox
End Class
