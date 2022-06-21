﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.Class;
using WABlockchain.SWLNBlockchainService;
using System.Globalization;

namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                if (Session["Rol"] != null)
                {
                    string Rol = Session["Rol"].ToString();
                    switch (Rol)
                    {
                        case "ReadOnly":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            break;
                        case "Secretaria":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = true;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            break;
                        case "Admin":
                            btnRegistrarUsuario.Visible = true;
                            btnRegistrarUsuarioNetvalle.Visible = true;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = false;
                            btnSolicitarTitulo.Visible = false;
                            btnRecibirTitulo.Visible = false;
                            break;
                        case "VRA":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarUsuarioNetvalle.Visible = false;
                            btnRegistrarTitulo.Visible = false;
                            btnConfirmarTitulo.Visible = true;
                            btnSolicitarTitulo.Visible = true;
                            btnRecibirTitulo.Visible = true;
                            break;
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("BRegistroUsuarioNuevo.aspx");
        }

        protected void btnRegistrarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BResgistroTitulo.aspx");
        }

        protected void btnRegistrarUsuarioNetvalle_Click(object sender, EventArgs e)
        {
            Response.Redirect("BVerUsuariosNetvalle.aspx");
        }

        protected void btnConfirmarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado2.aspx");
        }

        protected void btnSolicitarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado5.aspx");
        }

        protected void btnRecibirTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BEstado7.aspx");
        }
    }
}