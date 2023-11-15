using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de FirebaseStorageService
/// </summary>
public class FirebaseStorageService
{
    private static FirebaseStorage storage;

    static FirebaseStorageService()
    {
        var bucket = "controlserviciosocial-6759e.appspot.com";
        var auth = "";
        storage = new FirebaseStorage(bucket, new FirebaseStorageOptions
        {
            AuthTokenAsyncFactory = () => Task.FromResult(auth)
        });
    }

    public static async Task<string> UploadFile(Stream stream, string fileName)
    {
        var fileUrl = await storage
            .Child("certificados")
            .Child(fileName)
            .PutAsync(stream);

        return fileUrl;
    }

    public static async Task<FileResult> GetFile(string fileName)
    {
        try
        {
            var fileUrl = await storage
                .Child("certificados")
                .Child(fileName)
                .GetDownloadUrlAsync();

            Console.WriteLine(string.Format("URL del archivo: {0}", fileUrl));

            return new FileResult { FileUrl = fileUrl };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return new FileResult { Error = ex.ToString() };
        }
    }
}
public class FileResult
{
    public string FileUrl { get; set; }
    public string Error { get; set; }
}