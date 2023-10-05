using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Concesionario
{
    class Cliente
    {
        private string _cuit;
        private string _apellido;
        private string _nombre;
        private string _direccion;
        private int _telefono;
        private List<Venta> _listaVentas;
        private Ciudad _ciudad;

        public Cliente(string cuit, string apellido, string nombre, string direccion, int telefono, Ciudad locacion)
        {
            this.Cuit = cuit;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            _listaVentas = new List<Venta>();
            Ciudad = locacion;
        }

        public Ciudad Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public void MostrarCliente()
        {
            Console.WriteLine($"Provincia: {Ciudad.Provincia.Provincias}\nciudad: {Ciudad.Ciudades}\ncuit: {Cuit}\napellido: {Apellido}\nnombre: {Nombre}\ndireccion: {Direccion}\ntelefono: {Telefono}");
        }
    }
}
