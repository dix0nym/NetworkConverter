namespace Converter
{
    partial class frm1_converter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1_converter));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.btn_do = new System.Windows.Forms.Button();
            this.lb_uint16 = new System.Windows.Forms.Label();
            this.dgv_uint64 = new System.Windows.Forms.DataGridView();
            this.dgv_uint32 = new System.Windows.Forms.DataGridView();
            this.dgv_uint16 = new System.Windows.Forms.DataGridView();
            this.dgv_float = new System.Windows.Forms.DataGridView();
            this.dgv_ascii = new System.Windows.Forms.DataGridView();
            this.lb_float = new System.Windows.Forms.Label();
            this.lb_ascii = new System.Windows.Forms.Label();
            this.lb_uint64 = new System.Windows.Forms.Label();
            this.lb_uint32 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_big = new System.Windows.Forms.TextBox();
            this.txt_little = new System.Windows.Forms.TextBox();
            this.txtbox_dec_input = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_do_dec = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_float)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ascii)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtbox_input);
            this.tabPage1.Controls.Add(this.btn_do);
            this.tabPage1.Controls.Add(this.lb_uint16);
            this.tabPage1.Controls.Add(this.dgv_uint64);
            this.tabPage1.Controls.Add(this.dgv_uint32);
            this.tabPage1.Controls.Add(this.dgv_uint16);
            this.tabPage1.Controls.Add(this.dgv_float);
            this.tabPage1.Controls.Add(this.dgv_ascii);
            this.tabPage1.Controls.Add(this.lb_float);
            this.tabPage1.Controls.Add(this.lb_ascii);
            this.tabPage1.Controls.Add(this.lb_uint64);
            this.tabPage1.Controls.Add(this.lb_uint32);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 736);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HexConverter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtbox_input
            // 
            this.txtbox_input.Location = new System.Drawing.Point(8, 6);
            this.txtbox_input.Multiline = true;
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(764, 133);
            this.txtbox_input.TabIndex = 28;
            // 
            // btn_do
            // 
            this.btn_do.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_do.Location = new System.Drawing.Point(7, 145);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(765, 23);
            this.btn_do.TabIndex = 27;
            this.btn_do.Text = "do!";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // lb_uint16
            // 
            this.lb_uint16.AutoSize = true;
            this.lb_uint16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uint16.Location = new System.Drawing.Point(549, 176);
            this.lb_uint16.Name = "lb_uint16";
            this.lb_uint16.Size = new System.Drawing.Size(49, 15);
            this.lb_uint16.TabIndex = 26;
            this.lb_uint16.Text = "uint16";
            this.lb_uint16.DoubleClick += new System.EventHandler(this.lb_uint16_DoubleClick);
            // 
            // dgv_uint64
            // 
            this.dgv_uint64.AllowUserToAddRows = false;
            this.dgv_uint64.AllowUserToDeleteRows = false;
            this.dgv_uint64.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_uint64.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_uint64.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_uint64.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_uint64.Location = new System.Drawing.Point(315, 444);
            this.dgv_uint64.Name = "dgv_uint64";
            this.dgv_uint64.ReadOnly = true;
            this.dgv_uint64.RowHeadersVisible = false;
            this.dgv_uint64.Size = new System.Drawing.Size(457, 287);
            this.dgv_uint64.TabIndex = 25;
            this.dgv_uint64.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_uint64_CellContentClick);
            // 
            // dgv_uint32
            // 
            this.dgv_uint32.AllowUserToAddRows = false;
            this.dgv_uint32.AllowUserToDeleteRows = false;
            this.dgv_uint32.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_uint32.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_uint32.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_uint32.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_uint32.Location = new System.Drawing.Point(8, 444);
            this.dgv_uint32.Name = "dgv_uint32";
            this.dgv_uint32.ReadOnly = true;
            this.dgv_uint32.RowHeadersVisible = false;
            this.dgv_uint32.Size = new System.Drawing.Size(301, 287);
            this.dgv_uint32.TabIndex = 24;
            this.dgv_uint32.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_uint32_CellContentClick);
            // 
            // dgv_uint16
            // 
            this.dgv_uint16.AllowUserToAddRows = false;
            this.dgv_uint16.AllowUserToDeleteRows = false;
            this.dgv_uint16.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_uint16.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_uint16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_uint16.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_uint16.Location = new System.Drawing.Point(552, 194);
            this.dgv_uint16.Name = "dgv_uint16";
            this.dgv_uint16.ReadOnly = true;
            this.dgv_uint16.RowHeadersVisible = false;
            this.dgv_uint16.Size = new System.Drawing.Size(220, 211);
            this.dgv_uint16.TabIndex = 23;
            this.dgv_uint16.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_uint16_CellContentClick);
            // 
            // dgv_float
            // 
            this.dgv_float.AllowUserToAddRows = false;
            this.dgv_float.AllowUserToDeleteRows = false;
            this.dgv_float.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_float.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_float.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_float.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_float.Location = new System.Drawing.Point(302, 194);
            this.dgv_float.Name = "dgv_float";
            this.dgv_float.ReadOnly = true;
            this.dgv_float.RowHeadersVisible = false;
            this.dgv_float.Size = new System.Drawing.Size(244, 211);
            this.dgv_float.TabIndex = 22;
            this.dgv_float.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_float_CellContentClick);
            // 
            // dgv_ascii
            // 
            this.dgv_ascii.AllowUserToAddRows = false;
            this.dgv_ascii.AllowUserToDeleteRows = false;
            this.dgv_ascii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ascii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ascii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ascii.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ascii.Location = new System.Drawing.Point(8, 194);
            this.dgv_ascii.Name = "dgv_ascii";
            this.dgv_ascii.ReadOnly = true;
            this.dgv_ascii.RowHeadersVisible = false;
            this.dgv_ascii.Size = new System.Drawing.Size(288, 211);
            this.dgv_ascii.TabIndex = 21;
            this.dgv_ascii.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ascii_CellContentDoubleClick);
            // 
            // lb_float
            // 
            this.lb_float.AutoSize = true;
            this.lb_float.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_float.Location = new System.Drawing.Point(299, 178);
            this.lb_float.Name = "lb_float";
            this.lb_float.Size = new System.Drawing.Size(42, 15);
            this.lb_float.TabIndex = 20;
            this.lb_float.Text = "Float";
            this.lb_float.DoubleClick += new System.EventHandler(this.lb_float_DoubleClick);
            // 
            // lb_ascii
            // 
            this.lb_ascii.AutoSize = true;
            this.lb_ascii.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ascii.Location = new System.Drawing.Point(5, 178);
            this.lb_ascii.Name = "lb_ascii";
            this.lb_ascii.Size = new System.Drawing.Size(42, 15);
            this.lb_ascii.TabIndex = 19;
            this.lb_ascii.Text = "ASCII";
            this.lb_ascii.DoubleClick += new System.EventHandler(this.lb_ascii_DoubleClick);
            // 
            // lb_uint64
            // 
            this.lb_uint64.AutoSize = true;
            this.lb_uint64.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uint64.Location = new System.Drawing.Point(312, 426);
            this.lb_uint64.Name = "lb_uint64";
            this.lb_uint64.Size = new System.Drawing.Size(49, 15);
            this.lb_uint64.TabIndex = 18;
            this.lb_uint64.Text = "uint64";
            this.lb_uint64.DoubleClick += new System.EventHandler(this.lb_uint64_DoubleClick);
            // 
            // lb_uint32
            // 
            this.lb_uint32.AutoSize = true;
            this.lb_uint32.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uint32.Location = new System.Drawing.Point(5, 426);
            this.lb_uint32.Name = "lb_uint32";
            this.lb_uint32.Size = new System.Drawing.Size(49, 15);
            this.lb_uint32.TabIndex = 17;
            this.lb_uint32.Text = "uint32";
            this.lb_uint32.DoubleClick += new System.EventHandler(this.lb_uint32_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_big);
            this.tabPage2.Controls.Add(this.txt_little);
            this.tabPage2.Controls.Add(this.txtbox_dec_input);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_do_dec);
            this.tabPage2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 736);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DecConverter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_big
            // 
            this.txt_big.Location = new System.Drawing.Point(393, 209);
            this.txt_big.Multiline = true;
            this.txt_big.Name = "txt_big";
            this.txt_big.Size = new System.Drawing.Size(379, 127);
            this.txt_big.TabIndex = 36;
            // 
            // txt_little
            // 
            this.txt_little.Location = new System.Drawing.Point(7, 210);
            this.txt_little.Multiline = true;
            this.txt_little.Name = "txt_little";
            this.txt_little.Size = new System.Drawing.Size(379, 127);
            this.txt_little.TabIndex = 35;
            // 
            // txtbox_dec_input
            // 
            this.txtbox_dec_input.Location = new System.Drawing.Point(6, 6);
            this.txtbox_dec_input.Multiline = true;
            this.txtbox_dec_input.Name = "txtbox_dec_input";
            this.txtbox_dec_input.Size = new System.Drawing.Size(766, 133);
            this.txtbox_dec_input.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "BigEndian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "LittleEndian";
            // 
            // btn_do_dec
            // 
            this.btn_do_dec.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_do_dec.Location = new System.Drawing.Point(5, 145);
            this.btn_do_dec.Name = "btn_do_dec";
            this.btn_do_dec.Size = new System.Drawing.Size(767, 27);
            this.btn_do_dec.TabIndex = 29;
            this.btn_do_dec.Text = "do!";
            this.btn_do_dec.UseVisualStyleBackColor = true;
            this.btn_do_dec.Click += new System.EventHandler(this.btn_do_dec_Click);
            // 
            // frm1_converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 762);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm1_converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_uint16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_float)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ascii)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Label lb_uint16;
        private System.Windows.Forms.DataGridView dgv_uint64;
        private System.Windows.Forms.DataGridView dgv_uint32;
        private System.Windows.Forms.DataGridView dgv_uint16;
        private System.Windows.Forms.DataGridView dgv_float;
        private System.Windows.Forms.DataGridView dgv_ascii;
        private System.Windows.Forms.Label lb_float;
        private System.Windows.Forms.Label lb_ascii;
        private System.Windows.Forms.Label lb_uint64;
        private System.Windows.Forms.Label lb_uint32;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_do_dec;
        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.TextBox txt_big;
        private System.Windows.Forms.TextBox txt_little;
        private System.Windows.Forms.TextBox txtbox_dec_input;
    }
}

