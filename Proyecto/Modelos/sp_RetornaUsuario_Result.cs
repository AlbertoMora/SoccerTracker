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
    
    public partial class sp_RetornaUsuario_Result
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string hashed_pass { get; set; }
        public bool es_admin { get; set; }
        public bool estado { get; set; }
        public int id_persona { get; set; }
    }
}
