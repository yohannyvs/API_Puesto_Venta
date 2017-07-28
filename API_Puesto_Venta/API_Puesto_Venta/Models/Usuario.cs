using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Usuario
    {
        private int cedula;
        private string nombre;
        private string apellido;
        private string direc;
        private int telefono;
        private string correo;
        private string contraseña;
        private string uid;

        public Usuario() { }

        public Usuario(int cedula, string nombre, string apellido, string direc, int telefono, string correo, string contraseña, string uid)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direc = direc;
            this.telefono = telefono;
            this.correo = correo;
            this.contraseña = contraseña;
            this.uid = uid;
        }

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Direc
        {
            get { return direc; }
            set { direc = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }
    }
}