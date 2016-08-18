Public Class Enumerations
    Public Enum LoginMethod As Integer
        User = 0
        Admin = 1
        Unlock = 2
    End Enum

    Public Enum AccessType As Integer
        OnlyPassword = 0
        UsernamePassword = 1
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

    Public Enum SoundConfigMode As Integer
        Add = 0
        Modify = 1
    End Enum

    Public Enum CategoryConfigMode As Integer
        Add = 0
        Modify = 1
        ModifyDefault = 2
    End Enum

    Public Enum ImportStatus As Integer
        None = 0
        Success = 1
        SuccessWithFailure = 2
        Failure = 3
    End Enum
End Class
