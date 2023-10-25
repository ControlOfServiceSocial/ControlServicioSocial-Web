using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CControlServicioSocial
/// </summary>
public class CControlServicioSocial
{
    ASNETControlServicioSocial aSNETControlServicioSocial;
    public CControlServicioSocial()
    {
        aSNETControlServicioSocial = new ASNETControlServicioSocial();
    }
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto=new List<ECProyecto>();
        try
        {
            lstEcProyecto=aSNETControlServicioSocial.Obtener_CProyecto_O();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyecto;
    }
    public List<ECCertificado> Obtener_CCertificado_O()
    {
        List<ECCertificado> lstEcCertifiado = new List<ECCertificado>();
        try
        {
            lstEcCertifiado = aSNETControlServicioSocial.Obtener_CCertificado_O();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcCertifiado;
    }

    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
       ECProyecto eCProyecto=new ECProyecto();
        try
        {
            eCProyecto = aSNETControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyecto;
    }

    public ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante = aSNETControlServicioSocial.Obtener_CProyectoEstudiante_O();
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyectoEstudiante;
    }

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
    {
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        try
        {
            lstECProyectoEstudiante = aSNETControlServicioSocial.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyectoEstudiante;
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        try
        {
            lstECProyecto = aSNETControlServicioSocial.Obtener_CProyecto_O_CProyecto(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyecto;
    }

    public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
    {
        List<ECCertificado> lstECCertificado = new List<ECCertificado>();
        try
        {
            lstECCertificado = aSNETControlServicioSocial.Obtener_CCertificado_O_IdEstudiante(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstECCertificado;
    }

    public void Insertar_CCertificado_I(string documentoCertificado, int idEstudiante, string tituloCertificado, int cargaHoraria)
    {
        ECCertificado eCCertificado = new ECCertificado();
        try
        {
            eCCertificado.DocumentoCertificado = documentoCertificado;
            eCCertificado.IdEstudiante = idEstudiante;
            eCCertificado.TituloCertificado = tituloCertificado;
            eCCertificado.CargaHoraria = cargaHoraria;
            aSNETControlServicioSocial.Insertar_CCertificado_I(eCCertificado);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(int idEstudiante, DateTime horaFinal, string latitudFinal, string longitudFinal)
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante.IdEstudiante = idEstudiante;
            eCProyectoEstudiante.HoraFinal = horaFinal;
            eCProyectoEstudiante.LatitudFinal = latitudFinal;
            eCProyectoEstudiante.LongitudFinal = longitudFinal;
            aSNETControlServicioSocial.Actualizar_CProyectoEstudiante_A_HoraAcumulada(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Actualizar_CProyectoEstudiante_A_Inicio(int idEstudiante, DateTime horaInicio, string latitudInicial, string longitudInicial)
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante.IdEstudiante = idEstudiante;
            eCProyectoEstudiante.HoraInicio = horaInicio;
            eCProyectoEstudiante.LatitudInicial = latitudInicial;
            eCProyectoEstudiante.LongitudInicial = longitudInicial;
            aSNETControlServicioSocial.Actualizar_CProyectoEstudiante_A_Inicio(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }
}