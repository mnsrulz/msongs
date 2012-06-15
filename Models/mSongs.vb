Namespace mnsrulz.mSongsModels
#Region "Models"
    Public Class SongModel
        Property ID As Integer
        Property Title As String
        Property DownloadURL As String
        Property AlbumID As Integer
        Property Album As AlbumModel
    End Class

    Public Class AlbumModel
        Property ID As Integer
        Property Title As String
        Property Year As String
        Property Songs As SongsModel
    End Class

    Public Class SongsModel
        Inherits List(Of SongModel)
        Property TotalCount As Integer
        Property StartRow As Integer
        Property ItemCount As Integer
    End Class

    Public Class AlbumsModel
        Inherits List(Of AlbumModel)
        Property TotalCount As Integer
        Property StartRow As Integer
        Property ItemCount As Integer
    End Class
#End Region

#Region "Services"
    Public Class SongService

        Function ListSongs(ByVal search As String, ByVal startIndex As Integer, _
                           ByVal maxRows As Integer) As SongsModel
            Dim lstModel As New SongsModel
            For i = 0 To 9
                Dim o As New SongModel With {.AlbumID = 12, .ID = 12, .Title = "title" & i}
                lstModel.Add(o)
            Next
            lstModel.StartRow = 1
            lstModel.TotalCount = 10
            lstModel.ItemCount = 10
            Return lstModel
        End Function

    End Class

    Public Class AlbumService

        Shared Function ListAlbums() As AlbumsModel
            Dim lstModel As New AlbumsModel
            For i = 0 To 99
                Dim o As New AlbumModel With {.ID = i, .Title = "Album" & i, .Year = 1998}
                o.Songs = New SongsModel
                For j = 0 To 5
                    Dim k As New SongModel With {.AlbumID = i, .ID = i * j, .Title = "title" & i * j}
                    o.Songs.Add(k)
                Next
                lstModel.Add(o)
            Next
            Return lstModel
        End Function

        Shared Function GetAlbumByID(ByVal id As Integer) As AlbumModel
            Return (From t In ListAlbums() Where t.ID = id Select t).FirstOrDefault
        End Function

    End Class
#End Region

End Namespace