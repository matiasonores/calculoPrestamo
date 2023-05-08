
namespace calculadoraPrestamo
{
   partial class calculadoraPrestamo
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
         this.lbl_Monto = new System.Windows.Forms.Label();
         this.lb_calculo = new System.Windows.Forms.ListBox();
         this.btn_calcular = new System.Windows.Forms.Button();
         this.txt_monto = new System.Windows.Forms.TextBox();
         this.txt_meses = new System.Windows.Forms.TextBox();
         this.lbl_Meses = new System.Windows.Forms.Label();
         this.txt_taza = new System.Windows.Forms.TextBox();
         this.lbl_Taza = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txt_final = new System.Windows.Forms.TextBox();
         this.btn_limpiar = new System.Windows.Forms.Button();
         this.btn_salir = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lbl_Monto
         // 
         this.lbl_Monto.AutoSize = true;
         this.lbl_Monto.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_Monto.Location = new System.Drawing.Point(8, 13);
         this.lbl_Monto.Name = "lbl_Monto";
         this.lbl_Monto.Size = new System.Drawing.Size(205, 23);
         this.lbl_Monto.TabIndex = 0;
         this.lbl_Monto.Text = "Monto prestado:";
         // 
         // lb_calculo
         // 
         this.lb_calculo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lb_calculo.FormattingEnabled = true;
         this.lb_calculo.ItemHeight = 14;
         this.lb_calculo.Location = new System.Drawing.Point(12, 95);
         this.lb_calculo.Name = "lb_calculo";
         this.lb_calculo.Size = new System.Drawing.Size(347, 256);
         this.lb_calculo.TabIndex = 3;
         // 
         // btn_calcular
         // 
         this.btn_calcular.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_calcular.Location = new System.Drawing.Point(12, 399);
         this.btn_calcular.Name = "btn_calcular";
         this.btn_calcular.Size = new System.Drawing.Size(75, 40);
         this.btn_calcular.TabIndex = 4;
         this.btn_calcular.Text = "Calcular";
         this.btn_calcular.UseVisualStyleBackColor = true;
         this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
         // 
         // txt_monto
         // 
         this.txt_monto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_monto.Location = new System.Drawing.Point(232, 16);
         this.txt_monto.Name = "txt_monto";
         this.txt_monto.Size = new System.Drawing.Size(127, 20);
         this.txt_monto.TabIndex = 5;
         // 
         // txt_meses
         // 
         this.txt_meses.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
         this.txt_meses.Location = new System.Drawing.Point(232, 39);
         this.txt_meses.Name = "txt_meses";
         this.txt_meses.Size = new System.Drawing.Size(127, 20);
         this.txt_meses.TabIndex = 7;
         // 
         // lbl_Meses
         // 
         this.lbl_Meses.AutoSize = true;
         this.lbl_Meses.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_Meses.Location = new System.Drawing.Point(8, 36);
         this.lbl_Meses.Name = "lbl_Meses";
         this.lbl_Meses.Size = new System.Drawing.Size(218, 23);
         this.lbl_Meses.TabIndex = 6;
         this.lbl_Meses.Text = "Número de meses:";
         // 
         // txt_taza
         // 
         this.txt_taza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_taza.Location = new System.Drawing.Point(232, 62);
         this.txt_taza.Name = "txt_taza";
         this.txt_taza.Size = new System.Drawing.Size(127, 20);
         this.txt_taza.TabIndex = 9;
         // 
         // lbl_Taza
         // 
         this.lbl_Taza.AutoSize = true;
         this.lbl_Taza.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl_Taza.Location = new System.Drawing.Point(8, 59);
         this.lbl_Taza.Name = "lbl_Taza";
         this.lbl_Taza.Size = new System.Drawing.Size(218, 23);
         this.lbl_Taza.TabIndex = 8;
         this.lbl_Taza.Text = "Taza de interés:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(8, 363);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(166, 23);
         this.label1.TabIndex = 10;
         this.label1.Text = "Monto final:";
         // 
         // txt_final
         // 
         this.txt_final.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_final.Location = new System.Drawing.Point(232, 366);
         this.txt_final.Name = "txt_final";
         this.txt_final.Size = new System.Drawing.Size(127, 20);
         this.txt_final.TabIndex = 11;
         // 
         // btn_limpiar
         // 
         this.btn_limpiar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_limpiar.Location = new System.Drawing.Point(99, 399);
         this.btn_limpiar.Name = "btn_limpiar";
         this.btn_limpiar.Size = new System.Drawing.Size(75, 40);
         this.btn_limpiar.TabIndex = 12;
         this.btn_limpiar.Text = "Limpiar";
         this.btn_limpiar.UseVisualStyleBackColor = true;
         this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
         // 
         // btn_salir
         // 
         this.btn_salir.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btn_salir.Location = new System.Drawing.Point(284, 399);
         this.btn_salir.Name = "btn_salir";
         this.btn_salir.Size = new System.Drawing.Size(75, 40);
         this.btn_salir.TabIndex = 13;
         this.btn_salir.Text = "Salir";
         this.btn_salir.UseVisualStyleBackColor = true;
         this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
         // 
         // calculadoraPrestamo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(369, 450);
         this.Controls.Add(this.btn_salir);
         this.Controls.Add(this.btn_limpiar);
         this.Controls.Add(this.txt_final);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txt_taza);
         this.Controls.Add(this.lbl_Taza);
         this.Controls.Add(this.txt_meses);
         this.Controls.Add(this.lbl_Meses);
         this.Controls.Add(this.txt_monto);
         this.Controls.Add(this.btn_calcular);
         this.Controls.Add(this.lb_calculo);
         this.Controls.Add(this.lbl_Monto);
         this.Name = "calculadoraPrestamo";
         this.Text = "Cálculo de préstamo";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lbl_Monto;
      private System.Windows.Forms.ListBox lb_calculo;
      private System.Windows.Forms.Button btn_calcular;
      private System.Windows.Forms.TextBox txt_monto;
      private System.Windows.Forms.TextBox txt_meses;
      private System.Windows.Forms.Label lbl_Meses;
      private System.Windows.Forms.TextBox txt_taza;
      private System.Windows.Forms.Label lbl_Taza;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txt_final;
      private System.Windows.Forms.Button btn_limpiar;
      private System.Windows.Forms.Button btn_salir;
   }
}

