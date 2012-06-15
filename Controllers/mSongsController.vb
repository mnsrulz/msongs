Namespace mnsrulz

    Public Class mSongsController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /mSongs

        Function Index() As ActionResult
            Return View()
        End Function


        Function Albums(Optional ByVal page As Integer = 1) As ActionResult
            Dim o = mnsrulz.mSongsModels.AlbumService.ListAlbums
            ViewData("list") = o
            Return View()
        End Function

        Function Album(ByVal albumId As Integer) As ActionResult
            Dim o = mSongsModels.AlbumService.GetAlbumByID(albumId)
            Return View(o)
        End Function

        Function Songs(ByVal startRow As Integer, ByVal maxRows As Integer) As ActionResult
            Return View()
        End Function

        '<HttpGet()> _
        'Function Songs(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '<HttpPost()> _
        'Function Songs(ByVal id As Integer) As ActionResult
        '    Return View()
        'End Function

        '<HttpGet()> _
        'Function Songs(ByVal id As Integer, ByVal name As String) As ActionResult
        '    Return View()
        'End Function
    End Class
End Namespace