using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>

public class SBaseDatos
{

    public static Database BDSWADNETControlServicioSocial = DatabaseFactory.CreateDatabase("BDControlServicioSocialConnectionString");
}