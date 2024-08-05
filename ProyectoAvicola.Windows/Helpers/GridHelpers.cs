using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Windows.Helpers
{
    public static class GridHelpers
    {
        public static void MostrarDatosEnGrilla<T>(DataGridView dgv, List<T> lista) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(dgv, r);
            }
        }
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Alimento alimento:
                    r.Cells[0].Value = alimento.TipoAlimento;
                    break;
                case AlimentoDto alimentodto:
                    r.Cells[0].Value = alimentodto.TipoAlimento;
                    r.Cells[1].Value = alimentodto.Cantidad;
                    r.Cells[2].Value = alimentodto.Fecha.ToShortDateString();
                    break;
                case MedicamentoDto medicamentoDto:
                    r.Cells[0].Value = medicamentoDto.TipoMedicamento;
                    r.Cells[1].Value = medicamentoDto.Cantidad;
                    r.Cells[2].Value = medicamentoDto.Fecha.ToShortDateString();
                    break;
                case Medicamento medicamento:
                    r.Cells[0].Value = medicamento.TipoMedicamento;
                    break;
                case Localidad localidad:
                    r.Cells[0].Value = localidad.NombreLocalidad;
                    r.Cells[1].Value = localidad.CodigoPostal;
                    break;
                case ProveedorDto proveedor:
                    r.Cells[0].Value = $"{proveedor.ApellidoProveedor}, {proveedor.NombreProveedor}";
                    r.Cells[1].Value = proveedor.Telefono;
                    r.Cells[2].Value = proveedor.NombreLocalidad;
                    r.Cells[3].Value = proveedor.GranjasAsociadas;
                    break;
                case EmpleadoDto empleado:
                    r.Cells[0].Value = $"{empleado.ApellidoEmpleado}, {empleado.NombreEmpleado}";
                    r.Cells[1].Value = empleado.Telefono;
                    r.Cells[2].Value = empleado.NombreLocalidad;
                    r.Cells[3].Value = empleado.NombreGranja;
                    break;
                case GranjaDto granja:
                    r.Cells[0].Value = granja.NombreGranja;
                    r.Cells[1].Value = granja.NombreLocalidad;
                    r.Cells[2].Value = granja.Direccion;
                    r.Cells[3].Value = granja.NumeroDeGalpones;
                    r.Cells[4].Value = granja.NumeroDeEmpleados;
                    r.Cells[5].Value = granja.NumeroDeProveedores;
                    break;
                case GalponDto galpon:
                    r.Cells[0].Value = galpon.NombreGalpon;
                    r.Cells[2].Value = galpon.NombreGranja;
                    r.Cells[1].Value = galpon.Capacidad;
                    break;
                case DetalleGalponDto detalleGalpon:
                    r.Cells[0].Value = detalleGalpon.DetalleGalponId;
                    r.Cells[1].Value = detalleGalpon.GalponId;
                    r.Cells[3].Value = detalleGalpon.NombreGalpon;
                    r.Cells[2].Value = detalleGalpon.NombreGranja;
                    r.Cells[4].Value = detalleGalpon.FechaIngreso.ToShortDateString();
                    if (detalleGalpon.FechaEgreso != DateTime.MinValue)
                    {
                        r.Cells[7].Value = detalleGalpon.FechaEgreso.ToShortDateString();
                    }
                    else
                    {
                        r.Cells[7].Value = string.Empty;
                    }
                    r.Cells[6].Value = detalleGalpon.TotalIngreso;
                    r.Cells[5].Value = detalleGalpon.Capacidad;
                    break;
                case TransaccionDto transaccionDto:
                    r.Cells[0].Value = transaccionDto.Tipo;
                    r.Cells[1].Value = transaccionDto.Nombre;
                    r.Cells[2].Value = transaccionDto.Cantidad;
                    break;
                case TransaccionHistorial transaccionH:
                    r.Cells[0].Value = transaccionH.transaccionId;
                    r.Cells[1].Value = transaccionH.nombreProveedor;
                    r.Cells[2].Value = transaccionH.fecha.ToShortDateString();
                    break;
            }
            r.Tag = obj;

        }

        public static void CargarGrilla<T>(DataGridView DgvDatos, params string[] columnNames)
        {
            DgvDatos.Columns.Clear();

            foreach (var columnName in columnNames)
            {
                if (columnName != columnNames[0] || columnName=="N° Galpon")
                {
                    var columna = new DataGridViewTextBoxColumn();
                    columna.Name = "Columna" + columnName;
                    columna.HeaderText = columnName;
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    DgvDatos.Columns.Add(columna);
                }
            }
        }

    }
}
