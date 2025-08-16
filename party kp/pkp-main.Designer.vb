<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pkp_main
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pkp_main))
        kpMovementInterval = New Timer(components)
        kpShakeInterval = New Timer(components)
        kp = New PictureBox()
        CType(kp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' kpMovementInterval
        ' 
        kpMovementInterval.Enabled = True
        kpMovementInterval.Interval = 1500
        ' 
        ' kpShakeInterval
        ' 
        kpShakeInterval.Enabled = True
        ' 
        ' kp
        ' 
        kp.Image = My.Resources.Resources.IMG_52501
        kp.Location = New Point(2, 1)
        kp.Name = "kp"
        kp.Size = New Size(1105, 832)
        kp.SizeMode = PictureBoxSizeMode.StretchImage
        kp.TabIndex = 0
        kp.TabStop = False
        ' 
        ' pkp_main
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1105, 829)
        Controls.Add(kp)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "pkp_main"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "kp"
        TopMost = True
        CType(kp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents kpMovementInterval As Timer
    Friend WithEvents kpShakeInterval As Timer
    Friend WithEvents kp As PictureBox
End Class
