namespace Cronos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitulo = new Label();
            dataGridView1 = new DataGridView();
            activityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timerCronosBindingSource = new BindingSource(components);
            label2 = new Label();
            txtActivity = new TextBox();
            btnStart = new Button();
            btnStartNew = new Button();
            btnStop = new Button();
            btnReset = new Button();
            btnExport = new Button();
            lblTime = new Label();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timerCronosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(57, 21);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { activityDataGridViewTextBoxColumn, dateStartDataGridViewTextBoxColumn, dateEndDataGridViewTextBoxColumn });
            dataGridView1.DataSource = timerCronosBindingSource;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(512, 222);
            dataGridView1.TabIndex = 8;
            // 
            // activityDataGridViewTextBoxColumn
            // 
            activityDataGridViewTextBoxColumn.DataPropertyName = "Activity";
            activityDataGridViewTextBoxColumn.HeaderText = "Actividad";
            activityDataGridViewTextBoxColumn.Name = "activityDataGridViewTextBoxColumn";
            activityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            dateStartDataGridViewTextBoxColumn.HeaderText = "Inicio";
            dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            dateStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            dateEndDataGridViewTextBoxColumn.HeaderText = "Fin";
            dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timerCronosBindingSource
            // 
            timerCronosBindingSource.DataSource = typeof(TimerCronos);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 301);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Actividad:";
            // 
            // txtActivity
            // 
            txtActivity.Location = new Point(94, 298);
            txtActivity.Name = "txtActivity";
            txtActivity.Size = new Size(402, 23);
            txtActivity.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.ImageAlign = ContentAlignment.MiddleLeft;
            btnStart.ImageIndex = 0;
            btnStart.ImageList = imageList1;
            btnStart.Location = new Point(12, 346);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Iniciar";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStartNew
            // 
            btnStartNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartNew.ImageIndex = 1;
            btnStartNew.ImageList = imageList1;
            btnStartNew.Location = new Point(113, 346);
            btnStartNew.Name = "btnStartNew";
            btnStartNew.Size = new Size(101, 23);
            btnStartNew.TabIndex = 3;
            btnStartNew.Text = "Parcial";
            btnStartNew.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.ImageAlign = ContentAlignment.MiddleLeft;
            btnStop.ImageIndex = 2;
            btnStop.ImageList = imageList1;
            btnStop.Location = new Point(214, 346);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(101, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Detener";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.ImageIndex = 3;
            btnReset.ImageList = imageList1;
            btnReset.Location = new Point(315, 346);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(101, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnExport.ImageIndex = 4;
            btnExport.ImageList = imageList1;
            btnExport.Location = new Point(421, 346);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(103, 23);
            btnExport.TabIndex = 6;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(212, 388);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(112, 32);
            lblTime.TabIndex = 7;
            lblTime.Text = "00:00:00";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "timerstart.png");
            imageList1.Images.SetKeyName(1, "timerpause.png");
            imageList1.Images.SetKeyName(2, "timercancel.png");
            imageList1.Images.SetKeyName(3, "timerreset.png");
            imageList1.Images.SetKeyName(4, "export.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 429);
            Controls.Add(btnExport);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStartNew);
            Controls.Add(btnStart);
            Controls.Add(txtActivity);
            Controls.Add(lblTime);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cronos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)timerCronosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtActivity;
        private DataGridViewTextBoxColumn activityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private BindingSource timerCronosBindingSource;
        private Button btnStart;
        private Button btnStartNew;
        private Button btnStop;
        private Button btnReset;
        private Button btnExport;
        private Label lblTime;
        private ImageList imageList1;
    }
}