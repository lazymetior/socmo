
Partial Class socmo
    Inherits System.Web.UI.MasterPage

    Protected Function IsActive(targetPage As String) As String
        Dim currentPage As String = System.IO.Path.GetFileName(Request.Url.AbsolutePath)

        If currentPage.Equals(targetPage, StringComparison.OrdinalIgnoreCase) Then
            Return "nav-link text-primary"
        Else
            Return "nav-link text-white"
        End If
    End Function

   Protected Sub Nav(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' Get the current page's file name
        Dim currentPage As String = System.IO.Path.GetFileName(Request.Url.AbsolutePath)

        ' Check if the current page is Login.aspx or Signin.aspx
        If currentPage = "Login.aspx" OrElse currentPage = "Signin.aspx" Then
            ' Hide the ToggleNav control
            ToggleNav.Visible = False
        Else
            ' Show the ToggleNav control
            ToggleNav.Visible = True
        End If
    End Sub


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        ' Get the current page's file name
        Dim currentPage As String = System.IO.Path.GetFileName(Request.Url.AbsolutePath)

        ' Check if the current page is Search.aspx
        If currentPage = "Search.aspx" Then
            ' Show the search form
            searchForm.Visible = True
        Else
            ' Hide the search form
            searchForm.Visible = False
        End If
    End Sub


    Protected Sub Logout_Btns(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        ' Get the current page's file name
        Dim currentPage As String = System.IO.Path.GetFileName(Request.Url.AbsolutePath)

        ' Check if the current page is Search.aspx
        If currentPage = "Profile.aspx" Then
            ' Show the search form
            Logout_Btn.Visible = True
        Else
            ' Hide the search form
            Logout_Btn.Visible = False
        End If
    End Sub



End Class

