
namespace Practica_Interfaces
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlMenuClientes = new System.Windows.Forms.Panel();
            this.btnClienteCrear = new System.Windows.Forms.Button();
            this.btnClienteActualizar = new System.Windows.Forms.Button();
            this.btnClienteEliminar = new System.Windows.Forms.Button();
            this.btnClienteBuscar = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuariosBuscar = new System.Windows.Forms.Button();
            this.btnUsuariosEliminar = new System.Windows.Forms.Button();
            this.btnUsuariosActualizar = new System.Windows.Forms.Button();
            this.btnUsuariosCrear = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.pnlMenuCatalogos = new System.Windows.Forms.Panel();
            this.btnCatalogosBuscar = new System.Windows.Forms.Button();
            this.btnCatalogosEliminar = new System.Windows.Forms.Button();
            this.btnCatalogosActualizar = new System.Windows.Forms.Button();
            this.btnCatalogosCrear = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuClientes.SuspendLayout();
            this.pnlMenuUsuarios.SuspendLayout();
            this.pnlMenuCatalogos.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(this.pnlMenuCatalogos);
            this.pnlMenu.Controls.Add(this.btnCatalogos);
            this.pnlMenu.Controls.Add(this.pnlMenuUsuarios);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.pnlMenuClientes);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(325, 631);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnClientes.Location = new System.Drawing.Point(0, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(304, 59);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlMenuClientes
            // 
            this.pnlMenuClientes.Controls.Add(this.btnClienteBuscar);
            this.pnlMenuClientes.Controls.Add(this.btnClienteEliminar);
            this.pnlMenuClientes.Controls.Add(this.btnClienteActualizar);
            this.pnlMenuClientes.Controls.Add(this.btnClienteCrear);
            this.pnlMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuClientes.Location = new System.Drawing.Point(0, 59);
            this.pnlMenuClientes.Name = "pnlMenuClientes";
            this.pnlMenuClientes.Size = new System.Drawing.Size(304, 176);
            this.pnlMenuClientes.TabIndex = 2;
            // 
            // btnClienteCrear
            // 
            this.btnClienteCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteCrear.FlatAppearance.BorderSize = 0;
            this.btnClienteCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClienteCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnClienteCrear.Location = new System.Drawing.Point(0, 0);
            this.btnClienteCrear.Name = "btnClienteCrear";
            this.btnClienteCrear.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClienteCrear.Size = new System.Drawing.Size(304, 40);
            this.btnClienteCrear.TabIndex = 2;
            this.btnClienteCrear.Text = "Crear";
            this.btnClienteCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteCrear.UseVisualStyleBackColor = true;
            this.btnClienteCrear.Click += new System.EventHandler(this.btnClienteCrear_Click);
            // 
            // btnClienteActualizar
            // 
            this.btnClienteActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteActualizar.FlatAppearance.BorderSize = 0;
            this.btnClienteActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClienteActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnClienteActualizar.Location = new System.Drawing.Point(0, 40);
            this.btnClienteActualizar.Name = "btnClienteActualizar";
            this.btnClienteActualizar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClienteActualizar.Size = new System.Drawing.Size(304, 40);
            this.btnClienteActualizar.TabIndex = 3;
            this.btnClienteActualizar.Text = "Actualizar";
            this.btnClienteActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteActualizar.UseVisualStyleBackColor = true;
            // 
            // btnClienteEliminar
            // 
            this.btnClienteEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteEliminar.FlatAppearance.BorderSize = 0;
            this.btnClienteEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClienteEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnClienteEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnClienteEliminar.Name = "btnClienteEliminar";
            this.btnClienteEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClienteEliminar.Size = new System.Drawing.Size(304, 40);
            this.btnClienteEliminar.TabIndex = 4;
            this.btnClienteEliminar.Text = "Eliminar";
            this.btnClienteEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteEliminar.UseVisualStyleBackColor = true;
            // 
            // btnClienteBuscar
            // 
            this.btnClienteBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClienteBuscar.FlatAppearance.BorderSize = 0;
            this.btnClienteBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClienteBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnClienteBuscar.Location = new System.Drawing.Point(0, 120);
            this.btnClienteBuscar.Name = "btnClienteBuscar";
            this.btnClienteBuscar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnClienteBuscar.Size = new System.Drawing.Size(304, 40);
            this.btnClienteBuscar.TabIndex = 5;
            this.btnClienteBuscar.Text = "Buscar";
            this.btnClienteBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClienteBuscar.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 235);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(304, 59);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pnlMenuUsuarios
            // 
            this.pnlMenuUsuarios.Controls.Add(this.btnUsuariosBuscar);
            this.pnlMenuUsuarios.Controls.Add(this.btnUsuariosEliminar);
            this.pnlMenuUsuarios.Controls.Add(this.btnUsuariosActualizar);
            this.pnlMenuUsuarios.Controls.Add(this.btnUsuariosCrear);
            this.pnlMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuUsuarios.Location = new System.Drawing.Point(0, 294);
            this.pnlMenuUsuarios.Name = "pnlMenuUsuarios";
            this.pnlMenuUsuarios.Size = new System.Drawing.Size(304, 176);
            this.pnlMenuUsuarios.TabIndex = 4;
            // 
            // btnUsuariosBuscar
            // 
            this.btnUsuariosBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosBuscar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuariosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnUsuariosBuscar.Location = new System.Drawing.Point(0, 120);
            this.btnUsuariosBuscar.Name = "btnUsuariosBuscar";
            this.btnUsuariosBuscar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuariosBuscar.Size = new System.Drawing.Size(304, 40);
            this.btnUsuariosBuscar.TabIndex = 5;
            this.btnUsuariosBuscar.Text = "Buscar";
            this.btnUsuariosBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosBuscar.UseVisualStyleBackColor = true;
            // 
            // btnUsuariosEliminar
            // 
            this.btnUsuariosEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosEliminar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuariosEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnUsuariosEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnUsuariosEliminar.Name = "btnUsuariosEliminar";
            this.btnUsuariosEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuariosEliminar.Size = new System.Drawing.Size(304, 40);
            this.btnUsuariosEliminar.TabIndex = 4;
            this.btnUsuariosEliminar.Text = "Eliminar";
            this.btnUsuariosEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosEliminar.UseVisualStyleBackColor = true;
            // 
            // btnUsuariosActualizar
            // 
            this.btnUsuariosActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosActualizar.FlatAppearance.BorderSize = 0;
            this.btnUsuariosActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuariosActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnUsuariosActualizar.Location = new System.Drawing.Point(0, 40);
            this.btnUsuariosActualizar.Name = "btnUsuariosActualizar";
            this.btnUsuariosActualizar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuariosActualizar.Size = new System.Drawing.Size(304, 40);
            this.btnUsuariosActualizar.TabIndex = 3;
            this.btnUsuariosActualizar.Text = "Actualizar";
            this.btnUsuariosActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosActualizar.UseVisualStyleBackColor = true;
            // 
            // btnUsuariosCrear
            // 
            this.btnUsuariosCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosCrear.FlatAppearance.BorderSize = 0;
            this.btnUsuariosCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuariosCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnUsuariosCrear.Location = new System.Drawing.Point(0, 0);
            this.btnUsuariosCrear.Name = "btnUsuariosCrear";
            this.btnUsuariosCrear.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuariosCrear.Size = new System.Drawing.Size(304, 40);
            this.btnUsuariosCrear.TabIndex = 2;
            this.btnUsuariosCrear.Text = "Crear";
            this.btnUsuariosCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosCrear.UseVisualStyleBackColor = true;
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnCatalogos.Location = new System.Drawing.Point(0, 470);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCatalogos.Size = new System.Drawing.Size(304, 59);
            this.btnCatalogos.TabIndex = 5;
            this.btnCatalogos.Text = "Catalogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.UseVisualStyleBackColor = true;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // pnlMenuCatalogos
            // 
            this.pnlMenuCatalogos.Controls.Add(this.btnCatalogosBuscar);
            this.pnlMenuCatalogos.Controls.Add(this.btnCatalogosEliminar);
            this.pnlMenuCatalogos.Controls.Add(this.btnCatalogosActualizar);
            this.pnlMenuCatalogos.Controls.Add(this.btnCatalogosCrear);
            this.pnlMenuCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuCatalogos.Location = new System.Drawing.Point(0, 529);
            this.pnlMenuCatalogos.Name = "pnlMenuCatalogos";
            this.pnlMenuCatalogos.Size = new System.Drawing.Size(304, 176);
            this.pnlMenuCatalogos.TabIndex = 6;
            // 
            // btnCatalogosBuscar
            // 
            this.btnCatalogosBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogosBuscar.FlatAppearance.BorderSize = 0;
            this.btnCatalogosBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatalogosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogosBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnCatalogosBuscar.Location = new System.Drawing.Point(0, 120);
            this.btnCatalogosBuscar.Name = "btnCatalogosBuscar";
            this.btnCatalogosBuscar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCatalogosBuscar.Size = new System.Drawing.Size(304, 40);
            this.btnCatalogosBuscar.TabIndex = 5;
            this.btnCatalogosBuscar.Text = "Buscar";
            this.btnCatalogosBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogosBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCatalogosEliminar
            // 
            this.btnCatalogosEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogosEliminar.FlatAppearance.BorderSize = 0;
            this.btnCatalogosEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatalogosEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogosEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnCatalogosEliminar.Location = new System.Drawing.Point(0, 80);
            this.btnCatalogosEliminar.Name = "btnCatalogosEliminar";
            this.btnCatalogosEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCatalogosEliminar.Size = new System.Drawing.Size(304, 40);
            this.btnCatalogosEliminar.TabIndex = 4;
            this.btnCatalogosEliminar.Text = "Eliminar";
            this.btnCatalogosEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogosEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCatalogosActualizar
            // 
            this.btnCatalogosActualizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogosActualizar.FlatAppearance.BorderSize = 0;
            this.btnCatalogosActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatalogosActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogosActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnCatalogosActualizar.Location = new System.Drawing.Point(0, 40);
            this.btnCatalogosActualizar.Name = "btnCatalogosActualizar";
            this.btnCatalogosActualizar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCatalogosActualizar.Size = new System.Drawing.Size(304, 40);
            this.btnCatalogosActualizar.TabIndex = 3;
            this.btnCatalogosActualizar.Text = "Actualizar";
            this.btnCatalogosActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogosActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCatalogosCrear
            // 
            this.btnCatalogosCrear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogosCrear.FlatAppearance.BorderSize = 0;
            this.btnCatalogosCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCatalogosCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogosCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnCatalogosCrear.Location = new System.Drawing.Point(0, 0);
            this.btnCatalogosCrear.Name = "btnCatalogosCrear";
            this.btnCatalogosCrear.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCatalogosCrear.Size = new System.Drawing.Size(304, 40);
            this.btnCatalogosCrear.TabIndex = 2;
            this.btnCatalogosCrear.Text = "Crear";
            this.btnCatalogosCrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogosCrear.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pctLogo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(325, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(746, 631);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.Image = global::Practica_Interfaces.Properties.Resources.tsubaki;
            this.pctLogo.Location = new System.Drawing.Point(241, 195);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(304, 158);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1071, 631);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1089, 678);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuClientes.ResumeLayout(false);
            this.pnlMenuUsuarios.ResumeLayout(false);
            this.pnlMenuCatalogos.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMenuClientes;
        private System.Windows.Forms.Button btnClienteBuscar;
        private System.Windows.Forms.Button btnClienteEliminar;
        private System.Windows.Forms.Button btnClienteActualizar;
        private System.Windows.Forms.Button btnClienteCrear;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlMenuUsuarios;
        private System.Windows.Forms.Button btnUsuariosBuscar;
        private System.Windows.Forms.Button btnUsuariosEliminar;
        private System.Windows.Forms.Button btnUsuariosActualizar;
        private System.Windows.Forms.Button btnUsuariosCrear;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlMenuCatalogos;
        private System.Windows.Forms.Button btnCatalogosBuscar;
        private System.Windows.Forms.Button btnCatalogosEliminar;
        private System.Windows.Forms.Button btnCatalogosActualizar;
        private System.Windows.Forms.Button btnCatalogosCrear;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

