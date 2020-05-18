Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Public Declare Function GetPixel Lib "gdi32.dll" (ByVal hdc As IntPtr,
                                                      ByVal nXPos As Int32,
                                                      ByVal nYPos As Int32
                                                     ) As Int32

    Private Declare Function GetDC Lib "user32.dll" (ByVal hWnd As IntPtr) As IntPtr

    Private Declare Function ReleaseDC Lib "user32.dll" (ByVal hWnd As IntPtr,
                                                     ByVal hdc As IntPtr
                                                    ) As Int32

    Private mainhdc = New IntPtr()

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        mainhdc = GetDC(IntPtr.Zero)

        While True ' --- endless loop
            'BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X, Cursor.Position.Y))
            TextBox1.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 27, Cursor.Position.Y - 27))
            'TextBox1.Text = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X, Cursor.Position.Y)).ToArgb
            TextBox3.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 18, Cursor.Position.Y - 18))
            TextBox4.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 9, Cursor.Position.Y + 9))
            TextBox5.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X, Cursor.Position.Y))
            TextBox6.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 9, Cursor.Position.Y + 9))
            TextBox7.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 18, Cursor.Position.Y - 18))
            TextBox8.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 27, Cursor.Position.Y + 27))
            TextBox9.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 27, Cursor.Position.Y + 27))
            TextBox10.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 18, Cursor.Position.Y + 18))
            TextBox11.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 9, Cursor.Position.Y + 9))
            TextBox12.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 9, Cursor.Position.Y - 9))
            TextBox13.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 18, Cursor.Position.Y - 18))
            TextBox14.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 27, Cursor.Position.Y - 27))
            TextBox15.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 27, Cursor.Position.Y))
            TextBox16.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 18, Cursor.Position.Y))
            TextBox17.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X - 9, Cursor.Position.Y))
            TextBox18.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 9, Cursor.Position.Y))
            TextBox19.BackColor = ColorTranslator.FromWin32(GetPixel(mainhdc, Cursor.Position.X + 18, Cursor.Position.Y))


            Dim check As Integer

            If TextBox1.BackColor = Color.FromArgb(-4513246) Or
            TextBox3.BackColor = Color.FromArgb(-4513246) Or
            TextBox4.BackColor = Color.FromArgb(-4513246) Or
            TextBox5.BackColor = Color.FromArgb(-4513246) Or
            TextBox6.BackColor = Color.FromArgb(-4513246) Or
            TextBox7.BackColor = Color.FromArgb(-4513246) Or
            TextBox8.BackColor = Color.FromArgb(-4513246) Or
            TextBox9.BackColor = Color.FromArgb(-4513246) Or
            TextBox10.BackColor = Color.FromArgb(-4513246) Or
            TextBox11.BackColor = Color.FromArgb(-4513246) Or
            TextBox12.BackColor = Color.FromArgb(-4513246) Or
            TextBox13.BackColor = Color.FromArgb(-4513246) Or
            TextBox14.BackColor = Color.FromArgb(-4513246) Or
            TextBox15.BackColor = Color.FromArgb(-4513246) Or
            TextBox16.BackColor = Color.FromArgb(-4513246) Or
            TextBox17.BackColor = Color.FromArgb(-4513246) Or
            TextBox18.BackColor = Color.FromArgb(-4513246) Or
            TextBox19.BackColor = Color.FromArgb(-4513246) Then

                My.Computer.Keyboard.SendKeys(" ")
                My.Computer.Keyboard.SendKeys(" ")
                My.Computer.Keyboard.SendKeys(" ")
                TextBox2.Text = TextBox2.Text & "Ball Detected" & vbNewLine
                My.Computer.Keyboard.SendKeys(" ")
            Else
                Label1.Text = ""
            End If

            Application.DoEvents()
        End While

    End Sub




    Private onn As Boolean = False

    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer,
      ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer,
      ByVal dwExtraInfo As Integer)



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        onn = Not onn
    End Sub

    Private Sub ClickLeft(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If onn Then
            Select Case e.KeyChar
                Case "Z", "z", "X", "x"
                    mouse_event(&H2, 0, 0, 0, 0)
                    mouse_event(&H4, 0, 0, 0, 0)
            End Select
        End If
    End Sub


    Dim MyPointAPI As POINTAPI
    Private Structure POINTAPI
        Dim X As Long
        Dim Y As Long
    End Structure

    Private Declare Function GetCursorPos Lib "user32" (lpPoint As POINTAPI) As Long
    Public Sub Timer1_Timer()
        Dim l = GetCursorPos(MyPointAPI)
        Label1.Text = CStr(MyPointAPI.X) & ", " & CStr(MyPointAPI.Y)
    End Sub




End Class
