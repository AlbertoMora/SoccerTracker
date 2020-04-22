﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Clases;
using Proyecto.Modelos;

namespace Proyecto.Formularios
{
    public partial class frmEliminarTorneo : System.Web.UI.Page
    {
        int id_torneo;
        ProyectoBD modelo = new ProyectoBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            id_torneo = Int32.Parse(Request.QueryString["id_torneo"]);
        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            var cantPartidos = ((from c in modelo.Partidos
                                where c.id_campeonato == id_torneo
                                select c).Count());
            if (cantPartidos == 0)
            {
                try
                {
                    var torneo = new Campeonato { id = id_torneo };
                    modelo.Campeonatos.Attach(torneo);
                    modelo.Campeonatos.Remove(torneo);
                    modelo.SaveChanges();
                    Utilidades.CreateMessageandRedirect(ClientScript, GetType(), "El Torneo ha sido eliminado con éxito", "frmListaTorneos");
                }
                catch (Exception ex)
                {
                    string msg = "El torneo tiene eventos disputados y no es posible ser eliminado. Por favor comuníquese con su administrador web si necesita eliminar este registro";
                    Utilidades.CreateMessageandRedirect(ClientScript, GetType(), msg, "frmListaTorneos");
                }
            }
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Formularios/frmListaTorneos");
        }
    }
}