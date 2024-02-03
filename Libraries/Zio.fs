namespace Libraries.Zio

open Zio

module Directory =
    let create (path : UPath) (fs : IFileSystem) = fs.CreateDirectory path

    let delete (isRecursive : bool) (path : UPath) (fs : IFileSystem) = fs.DeleteDirectory (path, isRecursive)

    let exists (path : UPath) (fs : IFileSystem) = fs.DirectoryExists path

module File =
    let create (path : UPath) (fs : IFileSystem) = fs.CreateFile path

    let delete (path : UPath) (fs : IFileSystem) = fs.DeleteFile path

    let exists (path : UPath) (fs : IFileSystem) = fs.FileExists path
