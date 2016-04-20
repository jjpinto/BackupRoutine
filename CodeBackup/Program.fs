
let backupFiles () = CopyDataStructure.BackupFiles

[<EntryPoint>]
let main argv = 
    printfn "Starting backup..."
    backupFiles ()
    printfn "Backup is done!" 
    System.Console.ReadKey() |> ignore
    0  // return an integer exit code


