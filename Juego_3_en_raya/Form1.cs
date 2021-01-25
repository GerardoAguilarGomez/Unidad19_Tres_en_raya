using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_3_en_raya
{
    public partial class Form1 : Form
    {
        string nombre_jugador1;
        string nombre_jugador2;
        string simbolo_jugador1 = "X";
        string simbolo_jugador2 = "O";
        int movimientos_1 = 0;
        int movimientos_2 = 0;
        int turno = 1;
        string[,] tablero = new string[3,3];
        bool coger = false;
        int fila_quitar = 0;
        int col_quitar = 0;

        public void cambiar_turno()
        {
            if (turno == 1)
            {
                movimientos_1++;
                turno = 2;
            }
            else
            {
                movimientos_2++;
                turno = 1;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_comenzar_Click(object sender, EventArgs e)
        {
            bool comienzo = true;
            nombre_jugador1 = textBox1.Text;
            nombre_jugador2 = textBox2.Text;

            if (radioButton1.Checked==true) 
            {
                if (nombre_jugador1 == "")
                {
                    MessageBox.Show("Falta introducir el nombre del jugador 1");
                    comienzo = false;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (nombre_jugador2 == "")
                {
                    MessageBox.Show("Falta introducir el nombre del jugador 3");
                    comienzo = false;
                }
            }
            if (comienzo == true)
            {
                casilla1.Enabled = true;
                casilla2.Enabled = true;
                casilla3.Enabled = true;
                casilla4.Enabled = true;
                casilla5.Enabled = true;
                casilla6.Enabled = true;
                casilla7.Enabled = true;
                casilla8.Enabled = true;
                casilla9.Enabled = true;
            }
        }

        public int NumeroMovimientos(int tur)
        {
            if (tur == 1) {
                return movimientos_1;
            }
            else
            {
                return movimientos_2;
            }
        }

        private void casilla1_Click(object sender, EventArgs e)
        {
            if (tablero[0, 0] == null)
            {
                if (turno == 1)
                {
                    casilla1.Text = simbolo_jugador1;
                    tablero[0, 0] = simbolo_jugador1;

                }
                else
                {
                    casilla1.Text = simbolo_jugador2;
                    tablero[0, 0] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla1.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 0;
                        col_quitar = 0;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla1.Text = simbolo_jugador1;
                            tablero[0,0] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla1.Text = simbolo_jugador2;
                            tablero[0, 0] = simbolo_jugador2;
                        }
                        casilla2.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla2_Click(object sender, EventArgs e)
        {
            if (tablero[0, 1] == null)
            {
                if (turno == 1)
                {
                    casilla2.Text = simbolo_jugador1;
                    tablero[0, 1] = simbolo_jugador1;

                }
                else
                {
                    casilla2.Text = simbolo_jugador2;
                    tablero[0, 1] = simbolo_jugador2;
                }
                cambiar_turno();
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla2.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 0;
                        col_quitar = 1;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla2.Text = simbolo_jugador1;
                            tablero[0, 1] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla2.Text = simbolo_jugador2;
                            tablero[0, 1] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                    cambiar_turno();
                }
            }

            
        }

        private void casilla3_Click(object sender, EventArgs e)
        {
            if (tablero[0, 2] == null)
            {
                if (turno == 1)
                {
                    casilla3.Text = simbolo_jugador1;
                    tablero[0, 2] = simbolo_jugador1;

                }
                else
                {
                    casilla3.Text = simbolo_jugador2;
                    tablero[0, 2] = simbolo_jugador2;
                }
                cambiar_turno();
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla3.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 0;
                        col_quitar = 2;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla3.Text = simbolo_jugador1;
                            tablero[0, 2] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla3.Text = simbolo_jugador2;
                            tablero[0, 2] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                    cambiar_turno();
                }
            }

            
        }

        private void casilla4_Click(object sender, EventArgs e)
        {
            if (tablero[1, 0] == null)
            {
                if (turno == 1)
                {
                    casilla4.Text = simbolo_jugador1;
                    tablero[1, 0] = simbolo_jugador1;

                }
                else
                {
                    casilla4.Text = simbolo_jugador2;
                    tablero[1, 0] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla4.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 1;
                        col_quitar = 0;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla4.Text = simbolo_jugador1;
                            tablero[1, 0] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla4.Text = simbolo_jugador2;
                            tablero[1, 0] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla5_Click(object sender, EventArgs e)
        {
            if (tablero[1, 1] == null)
            {
                if (turno == 1)
                {
                    casilla5.Text = simbolo_jugador1;
                    tablero[1, 1] = simbolo_jugador1;

                }
                else
                {
                    casilla5.Text = simbolo_jugador2;
                    tablero[1, 1] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla5.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 1;
                        col_quitar = 1;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla5.Text = simbolo_jugador1;
                            tablero[1, 1] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla5.Text = simbolo_jugador2;
                            tablero[1, 1] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla6_Click(object sender, EventArgs e)
        {
            if (tablero[1, 2] == null)
            {
                if (turno == 1)
                {
                    casilla6.Text = simbolo_jugador1;
                    tablero[1, 2] = simbolo_jugador1;

                }
                else
                {
                    casilla6.Text = simbolo_jugador2;
                    tablero[1, 2] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla6.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 1;
                        col_quitar = 2;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla6.Text = simbolo_jugador1;
                            tablero[1, 2] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla6.Text = simbolo_jugador2;
                            tablero[1, 2] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla7_Click(object sender, EventArgs e)
        {
            if (tablero[2, 0] == null)
            {
                if (turno == 1)
                {
                    casilla7.Text = simbolo_jugador1;
                    tablero[2, 0] = simbolo_jugador1;

                }
                else
                {
                    casilla7.Text = simbolo_jugador2;
                    tablero[2, 0] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla7.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 2;
                        col_quitar = 0;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla7.Text = simbolo_jugador1;
                            tablero[2,0] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla7.Text = simbolo_jugador2;
                            tablero[2,0] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla8_Click(object sender, EventArgs e)
        {
            if (tablero[2, 1] == null)
            {
                if (turno == 1)
                {
                    casilla8.Text = simbolo_jugador1;
                    tablero[2, 1] = simbolo_jugador1;

                }
                else
                {
                    casilla8.Text = simbolo_jugador2;
                    tablero[2, 1] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla8.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 2;
                        col_quitar = 1;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla8.Text = simbolo_jugador1;
                            tablero[2, 1] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla8.Text = simbolo_jugador2;
                            tablero[2, 1] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        casilla9.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }

        private void casilla9_Click(object sender, EventArgs e)
        {
            if (tablero[2,2] == null)
            {
                if (turno == 1)
                {
                    casilla9.Text = simbolo_jugador1;
                    tablero[2, 2] = simbolo_jugador1;

                }
                else
                {
                    casilla9.Text = simbolo_jugador2;
                    tablero[2,2] = simbolo_jugador2;
                }
            }
            else
            {
                if (NumeroMovimientos(turno) < 3)
                {

                }
                else
                {
                    if (coger == false)
                    {
                        casilla9.BackColor = Color.Red;
                        coger = true;
                        fila_quitar = 2;
                        col_quitar = 2;
                    }
                    else
                    {
                        tablero[fila_quitar, col_quitar] = null;
                        if (turno == 1)
                        {

                            casilla9.Text = simbolo_jugador1;
                            tablero[2, 2] = simbolo_jugador1;

                        }
                        else
                        {
                            casilla9.Text = simbolo_jugador2;
                            tablero[2,2] = simbolo_jugador2;
                        }
                        casilla1.BackColor = Color.Gainsboro;
                        casilla3.BackColor = Color.Gainsboro;
                        casilla4.BackColor = Color.Gainsboro;
                        casilla5.BackColor = Color.Gainsboro;
                        casilla6.BackColor = Color.Gainsboro;
                        casilla7.BackColor = Color.Gainsboro;
                        casilla8.BackColor = Color.Gainsboro;
                        casilla2.BackColor = Color.Gainsboro;
                        coger = false;
                    }
                }
            }

            cambiar_turno();
        }
    }
}
