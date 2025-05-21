using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financiera_UI.UserControllers.InteresCompuesto
{
    public partial class CtrInteresCompuesto : UserControl
    {
        
            public CtrInteresCompuesto()
            {
                InitializeComponent();
                cboTipoCalculo.SelectedIndex = 0;
                cboPeriodoCapitalizacion.SelectedIndex = 0;
            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                try
                {
                    switch (cboTipoCalculo.SelectedIndex)
                    {
                        case 0: // Monto final (F)
                            CalcularMontoFinal();
                            break;
                        case 1: // Principal (P)
                            CalcularPrincipal();
                            break;
                        case 2: // Tasa de interés (i)
                            CalcularTasaInteres();
                            break;
                        case 3: // Tiempo (n)
                            CalcularTiempo();
                            break;
                        case 4: // Interés compuesto (I)
                            CalcularInteresCompuesto();
                            break;
                        case 5: // Anualidad (A)
                            CalcularAnualidad();
                            break;
                        case 6: // Valor Futuro de una Anualidad
                            CalcularValorFuturoAnualidad();
                            break;
                        case 7: // Valor Presente de una Anualidad
                            CalcularValorPresenteAnualidad();
                            break;
                        case 8: // Anualidad de Pago Único
                            CalcularAnualidadPagoUnico();
                            break;
                        case 9: // Amortización
                            CalcularAmortizacion();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el cálculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void CalcularMontoFinal()
            {
                // F = P(1+i)^n
                double principal = double.Parse(txtPrincipal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa de interés según el periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double montoFinal = principal * Math.Pow(1 + tasaAjustada, periodosTotales);

                MostrarResultado($"Monto Final (F): {montoFinal:C2}");
                MostrarDetallesCalculo($"F = P(1+i)^n = {principal:C2} × (1 + {tasaAjustada:P4})^{periodosTotales} = {montoFinal:C2}");
            }

            private void CalcularPrincipal()
            {
                // P = F / (1+i)^n
                double montoFinal = double.Parse(txtMontoFinal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa de interés según el periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double principal = montoFinal / Math.Pow(1 + tasaAjustada, periodosTotales);

                MostrarResultado($"Principal (P): {principal:C2}");
                MostrarDetallesCalculo($"P = F / (1+i)^n = {montoFinal:C2} / (1 + {tasaAjustada:P4})^{periodosTotales} = {principal:C2}");
            }

            private void CalcularTasaInteres()
            {
                // i = ((F/P)^(1/n)) - 1
                double montoFinal = double.Parse(txtMontoFinal.Text);
                double principal = double.Parse(txtPrincipal.Text);
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Periodos totales
                double periodosTotales = tiempo * periodoCapitalizacion;

                // Tasa de interés por periodo
                double tasaPorPeriodo = Math.Pow(montoFinal / principal, 1 / periodosTotales) - 1;

                // Tasa de interés anual
                double tasaAnual = tasaPorPeriodo * periodoCapitalizacion * 100;

                MostrarResultado($"Tasa de Interés Anual: {tasaAnual:F4}%");
                MostrarDetallesCalculo($"i = ((F/P)^(1/n)) - 1 = ((({montoFinal:C2}/{principal:C2})^(1/{periodosTotales})) - 1) × {periodoCapitalizacion} = {tasaAnual:F4}%");
            }

            private void CalcularTiempo()
            {
                // n = ln(F/P) / ln(1+i)
                double montoFinal = double.Parse(txtMontoFinal.Text);
                double principal = double.Parse(txtPrincipal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;

                // Calcular periodos totales
                double periodosTotales = Math.Log(montoFinal / principal) / Math.Log(1 + tasaAjustada);

                // Convertir a años
                double tiempoEnAnios = periodosTotales / periodoCapitalizacion;

                MostrarResultado($"Tiempo: {tiempoEnAnios:F2} años");
                MostrarDetallesCalculo($"n = ln(F/P) / ln(1+i) = ln({montoFinal:C2}/{principal:C2}) / ln(1+{tasaAjustada:P4}) = {periodosTotales:F2} periodos = {tiempoEnAnios:F2} años");
            }

            private void CalcularInteresCompuesto()
            {
                // I = F - P
                double montoFinal = double.Parse(txtMontoFinal.Text);
                double principal = double.Parse(txtPrincipal.Text);

                double interesCompuesto = montoFinal - principal;

                MostrarResultado($"Interés Compuesto: {interesCompuesto:C2}");
                MostrarDetallesCalculo($"I = F - P = {montoFinal:C2} - {principal:C2} = {interesCompuesto:C2}");
            }

            private void CalcularAnualidad()
            {
                // A = P[i(1+i)^n]/[(1+i)^n-1]
                double principal = double.Parse(txtPrincipal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double numerador = tasaAjustada * Math.Pow(1 + tasaAjustada, periodosTotales);
                double denominador = Math.Pow(1 + tasaAjustada, periodosTotales) - 1;
                double anualidad = principal * (numerador / denominador);

                MostrarResultado($"Anualidad (A): {anualidad:C2}");
                MostrarDetallesCalculo($"A = P[i(1+i)^n]/[(1+i)^n-1] = {principal:C2} × [{tasaAjustada:P4} × (1+{tasaAjustada:P4})^{periodosTotales}]/[(1+{tasaAjustada:P4})^{periodosTotales}-1] = {anualidad:C2}");
            }

            private void CalcularValorFuturoAnualidad()
            {
                // F = A[(1+i)^n-1]/i
                double anualidad = double.Parse(txtAnualidad.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double numerador = Math.Pow(1 + tasaAjustada, periodosTotales) - 1;
                double valorFuturo = anualidad * (numerador / tasaAjustada);

                MostrarResultado($"Valor Futuro de la Anualidad: {valorFuturo:C2}");
                MostrarDetallesCalculo($"F = A[(1+i)^n-1]/i = {anualidad:C2} × [(1+{tasaAjustada:P4})^{periodosTotales}-1]/{tasaAjustada:P4} = {valorFuturo:C2}");
            }

            private void CalcularValorPresenteAnualidad()
            {
                // P = A[1-1/(1+i)^n]/i
                double anualidad = double.Parse(txtAnualidad.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double numerador = 1 - 1 / Math.Pow(1 + tasaAjustada, periodosTotales);
                double valorPresente = anualidad * (numerador / tasaAjustada);

                MostrarResultado($"Valor Presente de la Anualidad: {valorPresente:C2}");
                MostrarDetallesCalculo($"P = A[1-1/(1+i)^n]/i = {anualidad:C2} × [1-1/(1+{tasaAjustada:P4})^{periodosTotales}]/{tasaAjustada:P4} = {valorPresente:C2}");
            }

            private void CalcularAnualidadPagoUnico()
            {
                // A = F[i/((1+i)^n-1)]
                double montoFinal = double.Parse(txtMontoFinal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                double denominador = Math.Pow(1 + tasaAjustada, periodosTotales) - 1;
                double anualidad = montoFinal * (tasaAjustada / denominador);

                MostrarResultado($"Anualidad de Pago Único: {anualidad:C2}");
                MostrarDetallesCalculo($"A = F[i/((1+i)^n-1)] = {montoFinal:C2} × [{tasaAjustada:P4}/((1+{tasaAjustada:P4})^{periodosTotales}-1)] = {anualidad:C2}");
            }

            private void CalcularAmortizacion()
            {
                double principal = double.Parse(txtPrincipal.Text);
                double tasaInteres = double.Parse(txtTasaInteres.Text) / 100;
                double tiempo = double.Parse(txtTiempo.Text);
                int periodoCapitalizacion = ObtenerFactorCapitalizacion();

                // Ajustar tasa según periodo de capitalización
                double tasaAjustada = tasaInteres / periodoCapitalizacion;
                double periodosTotales = tiempo * periodoCapitalizacion;

                // Calcular pago periódico (cuota)
                double numerador = tasaAjustada * Math.Pow(1 + tasaAjustada, periodosTotales);
                double denominador = Math.Pow(1 + tasaAjustada, periodosTotales) - 1;
                double pagoPeriodicoCuota = principal * (numerador / denominador);

                // Crear tabla de amortización
                string tablaAmortizacion = "Periodo | Cuota | Interés | Amortización | Saldo\n";
                tablaAmortizacion += "--------|-------|---------|--------------|-------\n";

                double saldoActual = principal;

                for (int periodo = 1; periodo <= periodosTotales; periodo++)
                {
                    double interesPeriodo = saldoActual * tasaAjustada;
                    double amortizacion = pagoPeriodicoCuota - interesPeriodo;
                    saldoActual -= amortizacion;

                    if (saldoActual < 0.01) saldoActual = 0; // Corrección para redondeo

                    tablaAmortizacion += $"{periodo} | {pagoPeriodicoCuota:C2} | {interesPeriodo:C2} | {amortizacion:C2} | {saldoActual:C2}\n";

                    // Para tablas muy largas, mostrar solo los primeros y últimos periodos
                    if (periodo == 10 && periodosTotales > 20)
                    {
                        tablaAmortizacion += "... | ... | ... | ... | ...\n";
                        periodo = (int)periodosTotales - 5;
                    }
                }

                MostrarResultado($"Pago periódico: {pagoPeriodicoCuota:C2}");
                MostrarDetallesCalculo(tablaAmortizacion);
            }

            private int ObtenerFactorCapitalizacion()
            {
                switch (cboPeriodoCapitalizacion.SelectedIndex)
                {
                    case 0: // Anual
                        return 1;
                    case 1: // Semestral
                        return 2;
                    case 2: // Trimestral
                        return 4;
                    case 3: // Bimestral
                        return 6;
                    case 4: // Mensual
                        return 12;
                    case 5: // Quincenal
                        return 24;
                    case 6: // Semanal
                        return 52;
                    case 7: // Diario
                        return 365;
                    default:
                        return 1;
                }
            }

            private void MostrarResultado(string resultado)
            {
                lblResultado.Text = resultado;
            }

            private void MostrarDetallesCalculo(string detalles)
            {
                txtDetallesCalculo.Text = detalles;
            }

            private void cboTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Resetear todos los campos
                ResetearCampos();

                // Configurar campos según el tipo de cálculo seleccionado
                switch (cboTipoCalculo.SelectedIndex)
                {
                    case 0: // Monto final (F)
                        ConfigurarCamposCalculoMontoFinal();
                        break;
                    case 1: // Principal (P)
                        ConfigurarCamposCalculoPrincipal();
                        break;
                    case 2: // Tasa de interés (i)
                        ConfigurarCamposCalculoTasaInteres();
                        break;
                    case 3: // Tiempo (n)
                        ConfigurarCamposCalculoTiempo();
                        break;
                    case 4: // Interés compuesto (I)
                        ConfigurarCamposCalculoInteresCompuesto();
                        break;
                    case 5: // Anualidad (A)
                        ConfigurarCamposCalculoAnualidad();
                        break;
                    case 6: // Valor Futuro de una Anualidad
                        ConfigurarCamposCalculoValorFuturoAnualidad();
                        break;
                    case 7: // Valor Presente de una Anualidad
                        ConfigurarCamposCalculoValorPresenteAnualidad();
                        break;
                    case 8: // Anualidad de Pago Único
                        ConfigurarCamposCalculoAnualidadPagoUnico();
                        break;
                    case 9: // Amortización
                        ConfigurarCamposCalculoAmortizacion();
                        break;
                }
            }

            private void ResetearCampos()
            {
                // Deshabilitar todos los campos y labels
                lblPrincipal.Enabled = lblMontoFinal.Enabled = lblTasaInteres.Enabled =
                lblTiempo.Enabled = lblAnualidad.Enabled = false;

                txtPrincipal.Enabled = txtMontoFinal.Enabled = txtTasaInteres.Enabled =
                txtTiempo.Enabled = txtAnualidad.Enabled = false;

                // Limpiar resultado y detalles
                lblResultado.Text = "";
                txtDetallesCalculo.Text = "";
            }

            private void ConfigurarCamposCalculoMontoFinal()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoPrincipal()
            {
                lblMontoFinal.Enabled = txtMontoFinal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoTasaInteres()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblMontoFinal.Enabled = txtMontoFinal.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoTiempo()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblMontoFinal.Enabled = txtMontoFinal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
            }

            private void ConfigurarCamposCalculoInteresCompuesto()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblMontoFinal.Enabled = txtMontoFinal.Enabled = true;
            }

            private void ConfigurarCamposCalculoAnualidad()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoValorFuturoAnualidad()
            {
                lblAnualidad.Enabled = txtAnualidad.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoValorPresenteAnualidad()
            {
                lblAnualidad.Enabled = txtAnualidad.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoAnualidadPagoUnico()
            {
                lblMontoFinal.Enabled = txtMontoFinal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }

            private void ConfigurarCamposCalculoAmortizacion()
            {
                lblPrincipal.Enabled = txtPrincipal.Enabled = true;
                lblTasaInteres.Enabled = txtTasaInteres.Enabled = true;
                lblTiempo.Enabled = txtTiempo.Enabled = true;
            }
        }
    }

