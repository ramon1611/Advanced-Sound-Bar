Imports System.Security.Cryptography, System.Text
Imports System.Xml

Public Class Functions
    Public Shared SoundsAbsPath As String = Application.StartupPath + My.Settings.SoundsPath

    Public Enum LoginMethod As Integer
        User = 0
        Admin = 1
        Unlock = 2
    End Enum

    Public Enum StatusType As Integer
        Normal = 0
        Failure = 1
        Success = 2
        Warning = 3
    End Enum

    Public Enum LetterCase As Integer
        UpperCase = 0
        LowerCase = 1
        Normal = 2
    End Enum

    Public Structure Sound
        Public Name As String
        Public Path As String
        Public Duration As String
        Public Category As String

        Public Sub New(ByVal n As String, ByVal p As String, ByVal d As String, ByVal c As String)
            Name = n
            Path = p
            Duration = d
            Category = c
        End Sub
    End Structure

    Public Structure Category
        Public Name As String
        Public IsDefault As Boolean

        Public Sub New(ByVal n As String, Optional d As Boolean = False)
            Name = n
            IsDefault = d
        End Sub
    End Structure

    Public Shared Function LoadSounds(ByVal XmlFile As String) As List(Of Sound)
        Return SoundsXMLReader(XmlFile)
    End Function

    Public Shared Function LoadCategories(ByVal XmlFile As String) As List(Of Category)
        Return CategoriesXMLReader(XmlFile)
    End Function

    Public Shared Sub CategoriesXMLWriter(ByVal XmlFile As String, ByVal CategoriesData As List(Of Category))
        Try
            ' Auswahl einer Kodierungsart für die Zeichenablage
            Dim enc As New System.Text.UnicodeEncoding
            ' XmlTextWriter-Objekt für unsere Ausgabedatei erzeugen:
            Dim XMLobj As XmlTextWriter = New XmlTextWriter(XmlFile, enc)

            With XMLobj
                ' Formatierung: 4er-Einzüge verwenden
                .Formatting = Formatting.Indented
                .Indentation = 4
                ' Dann fangen wir mal an:
                .WriteStartDocument()
                ' Beginn eines Elements "Personen". Darin werden wir mehrere
                ' Elemente "Person" unterbringen.
                .WriteStartElement("Categories")
                ' Hier kommt das erste Element "Person". Eine Person hat
                ' in unserem einfachen Beispiel einen Titel, einen Nach-
                ' namen und einen Vornamen. Als Demo soll uns das genügen.

                Dim defaultIsSet As Boolean = False
                For Each SoundItem In CategoriesData
                    .WriteStartElement("Category") ' <Category
                    .WriteAttributeString("Name", SoundItem.Name)
                    If SoundItem.IsDefault = True And defaultIsSet = False Then : .WriteAttributeString("Default", SoundItem.IsDefault.ToString) : defaultIsSet = True : End If
                    .WriteEndElement() ' Category />
                Next

                ' Nachdem das Element "Personen" zwei Elemente "Person"
                ' erhalten hat, beenden wir die Ausgabe für "Personen"...
                .WriteEndElement() ' </Personen>
                ' ... und schließen das XML-Dokument (und die Datei)
                .Close() ' Document
            End With
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Public Shared Function CategoriesXMLReader(ByVal XmlFile As String) As List(Of Category)
        Try
            Dim Categories As New List(Of Category)
            ' Wir benötigen einen XmlReader für das Auslesen der XML-Datei
            Dim XMLRead As XmlReader = New XmlTextReader(XmlFile)

            ' Es folgt das Auslesen der XML-Datei
            With XMLRead
                Dim defaultIsSet As Boolean = False
                Do While .Read ' Es sind noch Daten vorhanden
                    ' Welche Art von Daten liegt an?
                    Select Case .NodeType
                        ' Ein Element
                        Case XmlNodeType.Element
                            Dim cName As String = String.Empty
                            Dim cDefault As Boolean = False

                            ' Alle Attribute (Name-Wert-Paare) abarbeiten
                            If .AttributeCount > 0 Then
                                ' Es sind noch weitere Attribute vorhanden
                                While .MoveToNextAttribute ' nächstes
                                    Select Case .Name
                                        Case "Name"
                                            cName = .Value
                                        Case "Default"
                                            If defaultIsSet = False Then : cDefault = CBool(.Value) : defaultIsSet = True : End If
                                        Case Else
                                    End Select
                                End While

                                If cName <> String.Empty Then
                                    Categories.Add(New Category(cName, cDefault))
                                End If
                            End If
                    End Select
                Loop  ' Weiter nach Daten schauen
                .Close()  ' XMLTextReader schließen
            End With

            Return Categories
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
            End
        End Try
    End Function

    Public Shared Sub SoundsXMLWriter(ByVal XmlFile As String, ByVal SoundsData As List(Of Sound))
        Try
            ' Auswahl einer Kodierungsart für die Zeichenablage
            Dim enc As New System.Text.UnicodeEncoding
            ' XmlTextWriter-Objekt für unsere Ausgabedatei erzeugen:
            Dim XMLobj As XmlTextWriter = New XmlTextWriter(XmlFile, enc)

            With XMLobj
                ' Formatierung: 4er-Einzüge verwenden
                .Formatting = Formatting.Indented
                .Indentation = 4
                ' Dann fangen wir mal an:
                .WriteStartDocument()
                ' Beginn eines Elements "Personen". Darin werden wir mehrere
                ' Elemente "Person" unterbringen.
                .WriteStartElement("Sounds")

                ' Hier kommt das erste Element "Person". Eine Person hat
                ' in unserem einfachen Beispiel einen Titel, einen Nach-
                ' namen und einen Vornamen. Als Demo soll uns das genügen.

                For Each SoundItem In SoundsData
                    .WriteStartElement("Sound") ' <Sound
                    .WriteAttributeString("Name", SoundItem.Name)
                    .WriteAttributeString("Path", SoundItem.Path)
                    .WriteAttributeString("Duration", SoundItem.Duration)
                    .WriteAttributeString("Category", SoundItem.Category)
                    .WriteEndElement() ' Sound />
                Next

                ' Nachdem das Element "Personen" zwei Elemente "Person"
                ' erhalten hat, beenden wir die Ausgabe für "Personen"...
                .WriteEndElement() ' </Personen>
                ' ... und schließen das XML-Dokument (und die Datei)
                .Close() ' Document
            End With
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Public Shared Function SoundsXMLReader(ByVal XmlFile As String) As List(Of Sound)
        Try
            Dim Sounds As New List(Of Sound)
            ' Wir benötigen einen XmlReader für das Auslesen der XML-Datei
            Dim XMLRead As XmlReader = New XmlTextReader(XmlFile)

            ' Es folgt das Auslesen der XML-Datei
            With XMLRead
                Do While .Read ' Es sind noch Daten vorhanden
                    ' Welche Art von Daten liegt an?
                    Select Case .NodeType
                        ' Ein Element
                        Case XmlNodeType.Element
                            Dim sName As String = String.Empty
                            Dim sPath As String = String.Empty
                            Dim sDuration As String = String.Empty
                            Dim sGroup As String = String.Empty

                            ' Alle Attribute (Name-Wert-Paare) abarbeiten
                            If .AttributeCount > 0 Then
                                ' Es sind noch weitere Attribute vorhanden
                                While .MoveToNextAttribute ' nächstes
                                    Select Case .Name
                                        Case "Name"
                                            sName = .Value
                                        Case "Path"
                                            sPath = .Value
                                        Case "Duration"
                                            sDuration = .Value
                                        Case "Group"
                                            sGroup = .Value
                                        Case Else
                                    End Select
                                End While

                                If sName <> String.Empty And sPath <> String.Empty Then
                                    Sounds.Add(New Sound(sName, sPath, sDuration, sGroup))
                                End If
                            End If
                    End Select
                Loop  ' Weiter nach Daten schauen
                .Close()  ' XMLTextReader schließen
            End With

            Return Sounds
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
            End
        End Try
    End Function

    Public Shared Sub ThrowExceptionMessageBox(ByVal ex As Exception, Optional ByVal UserFriendlyMessage As String = "Es ist ein Kritischer Fehler aufgetreten, bitte melden Sie dies dem Autor dieser Anwendung!", Optional ByVal Caption As String = "Kritischer Fehler")
        Dim st As New StackTrace(True)
        st = New StackTrace(ex, True)

        Dim errorFile As String = st.GetFrame(0).GetFileName
        If errorFile = Nothing Then : errorFile = st.GetFrame(0).GetMethod.Module.FullyQualifiedName : End If

        MessageBox.Show(UserFriendlyMessage + vbNewLine + vbNewLine + _
                        "##> Product Information: " + Application.ProductName + " (v" + Application.ProductVersion + ") <##" + vbNewLine + _
                        "##> Error File: " + errorFile + " <##" + vbNewLine + _
                        "##> Error Class: " + st.GetFrame(0).GetMethod.DeclaringType.FullName + " <##" + vbNewLine + _
                        "##> Error Mehtod: " + st.GetFrame(0).GetMethod.Name + " <##" + vbNewLine + _
                        "##> Error Line: " + st.GetFrame(0).GetFileLineNumber().ToString + " <##" + vbNewLine + _
                        "##> Error Message: " + vbNewLine + ex.Message + vbNewLine + " <##", _
                        Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub SubmitStatus(ByVal Sender As Form, ByVal Obj As ToolStripStatusLabel, Optional ByVal StatusType As StatusType = Functions.StatusType.Normal, Optional ByVal StatusMessage As String = "Bereit")
        Try
            Select Case StatusType
                Case StatusType.Failure
                    Obj.ForeColor = Color.Crimson
                Case StatusType.Success
                    Obj.ForeColor = Color.Green
                Case StatusType.Warning
                    Obj.ForeColor = Color.DarkOrange
                Case StatusType.Normal
                    Obj.ForeColor = Sender.ForeColor
                Case Else
                    Obj.ForeColor = Sender.ForeColor
            End Select

            Obj.Text = StatusMessage
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Public Shared Function MD5StringHash(ByVal strString As String, Optional ByVal LetterCase As LetterCase = LetterCase.LowerCase) As String
        Try
            Dim MD5 As New MD5CryptoServiceProvider
            Dim Data As Byte()
            Dim Result As Byte()
            Dim Res As String = ""
            Dim Tmp As String = ""
            Data = Encoding.ASCII.GetBytes(strString)
            Result = MD5.ComputeHash(Data)
            For i As Integer = 0 To Result.Length - 1
                Tmp = Hex(Result(i))
                If Len(Tmp) = 1 Then Tmp = "0" & Tmp
                Res += Tmp
            Next

            Select Case LetterCase
                Case Functions.LetterCase.LowerCase
                    Return Res.ToLower
                Case Functions.LetterCase.UpperCase
                    Return Res.ToUpper
                Case Functions.LetterCase.Normal
                    Return Res
                Case Else
                    Return Res
            End Select
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
            End
        End Try
    End Function
End Class
