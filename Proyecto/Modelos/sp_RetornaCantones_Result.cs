//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Modelos
{
    using System;
    
    public partial class sp_RetornaCantones_Result
    {
        public int id_canton { get; set; }
        public int id_provincia { get; set; }
        public string nombre { get; set; }
        public string Provincia { get; set; }
        public string usuario_creacion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public string usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_ult_mod { get; set; }
        public string vc_estado { get; set; }
        public int id_canton_inec { get; set; }
    }
}
