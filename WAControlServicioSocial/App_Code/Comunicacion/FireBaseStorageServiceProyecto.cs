using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Firebase.Storage;

/// <summary>
/// Descripción breve de FireBaseStorageServiceProyecto
/// </summary>
public class FireBaseStorageServiceProyecto
{

    private static FirebaseStorage storage;

    static FireBaseStorageServiceProyecto()
    {
        var bucket = "controlserviciosocial-6759e.appspot.com";
        var auth = "";
        storage = new FirebaseStorage(bucket, new FirebaseStorageOptions
        {
            AuthTokenAsyncFactory = () => Task.FromResult(auth)
        });
    }

    public static async Task<string> UploadImage(Stream imageStream, string imageName)
    {
        try
        {
            var fileUrl = await storage
                .Child("imagenes") // Cambia a la carpeta deseada en tu almacenamiento
                .Child(imageName)
                .PutAsync(imageStream);

            if (fileUrl != null)
            {
                // La operación PutAsync se completó con éxito
                return fileUrl;
            }
            else
            {
                // Ocurrió un problema durante la operación de subida
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return null;
        }
    }
}   