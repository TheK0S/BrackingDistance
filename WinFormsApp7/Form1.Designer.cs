namespace WinFormsApp7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            skinTires = new RadioButton();
            winterTires = new RadioButton();
            summerTires = new RadioButton();
            label3 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            weather_ice = new RadioButton();
            weather_dry = new RadioButton();
            weather_rain = new RadioButton();
            weather_snow = new RadioButton();
            panel6 = new Panel();
            primming = new RadioButton();
            gravel = new RadioButton();
            asphalt = new RadioButton();
            label4 = new Label();
            panel2 = new Panel();
            brackingDistanceField = new TextBox();
            calculate = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 499);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 0, 1);
            tableLayoutPanel1.Controls.Add(panel6, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.76395F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.23605F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 132F));
            tableLayoutPanel1.Size = new Size(206, 499);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(skinTires);
            panel3.Controls.Add(winterTires);
            panel3.Controls.Add(summerTires);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 127);
            panel3.TabIndex = 12;
            // 
            // skinTires
            // 
            skinTires.AutoSize = true;
            skinTires.ForeColor = Color.LightGray;
            skinTires.Location = new Point(25, 96);
            skinTires.Name = "skinTires";
            skinTires.Size = new Size(113, 22);
            skinTires.TabIndex = 10;
            skinTires.Text = "Лысая резина";
            skinTires.UseVisualStyleBackColor = true;
            // 
            // winterTires
            // 
            winterTires.AutoSize = true;
            winterTires.ForeColor = Color.LightGray;
            winterTires.Location = new Point(25, 68);
            winterTires.Name = "winterTires";
            winterTires.Size = new Size(121, 22);
            winterTires.TabIndex = 9;
            winterTires.Text = "Зимняя резина";
            winterTires.UseVisualStyleBackColor = true;
            // 
            // summerTires
            // 
            summerTires.AutoSize = true;
            summerTires.Checked = true;
            summerTires.ForeColor = Color.LightGray;
            summerTires.Location = new Point(25, 40);
            summerTires.Name = "summerTires";
            summerTires.Size = new Size(119, 22);
            summerTires.TabIndex = 8;
            summerTires.TabStop = true;
            summerTires.Text = "Летняя резина";
            summerTires.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(4, 10);
            label3.Name = "label3";
            label3.Size = new Size(192, 18);
            label3.TabIndex = 7;
            label3.Text = "Шины";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 75);
            panel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.LightGray;
            textBox1.Location = new Point(25, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 26);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(4, 8);
            label1.Name = "label1";
            label1.Size = new Size(192, 18);
            label1.TabIndex = 0;
            label1.Text = "Скорость автомобиля км/ч";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(weather_ice);
            panel5.Controls.Add(weather_dry);
            panel5.Controls.Add(weather_rain);
            panel5.Controls.Add(weather_snow);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 146);
            panel5.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(4, 4);
            label2.Name = "label2";
            label2.Size = new Size(192, 18);
            label2.TabIndex = 10;
            label2.Text = "Погодные условия";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weather_ice
            // 
            weather_ice.Anchor = AnchorStyles.None;
            weather_ice.AutoSize = true;
            weather_ice.ForeColor = Color.LightGray;
            weather_ice.Location = new Point(25, 115);
            weather_ice.Name = "weather_ice";
            weather_ice.Size = new Size(78, 22);
            weather_ice.TabIndex = 11;
            weather_ice.Text = "Гололед";
            weather_ice.UseVisualStyleBackColor = true;
            // 
            // weather_dry
            // 
            weather_dry.Anchor = AnchorStyles.None;
            weather_dry.AutoSize = true;
            weather_dry.Checked = true;
            weather_dry.ForeColor = Color.LightGray;
            weather_dry.Location = new Point(25, 31);
            weather_dry.Name = "weather_dry";
            weather_dry.Size = new Size(109, 22);
            weather_dry.TabIndex = 7;
            weather_dry.TabStop = true;
            weather_dry.Text = "Сухая погода";
            weather_dry.UseVisualStyleBackColor = true;
            // 
            // weather_rain
            // 
            weather_rain.Anchor = AnchorStyles.None;
            weather_rain.AutoSize = true;
            weather_rain.ForeColor = Color.LightGray;
            weather_rain.Location = new Point(25, 59);
            weather_rain.Name = "weather_rain";
            weather_rain.Size = new Size(69, 22);
            weather_rain.TabIndex = 8;
            weather_rain.Text = "Дождь";
            weather_rain.UseVisualStyleBackColor = true;
            // 
            // weather_snow
            // 
            weather_snow.Anchor = AnchorStyles.None;
            weather_snow.AutoSize = true;
            weather_snow.ForeColor = Color.LightGray;
            weather_snow.Location = new Point(25, 87);
            weather_snow.Name = "weather_snow";
            weather_snow.Size = new Size(55, 22);
            weather_snow.TabIndex = 9;
            weather_snow.Text = "Снег";
            weather_snow.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(primming);
            panel6.Controls.Add(gravel);
            panel6.Controls.Add(asphalt);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 369);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 127);
            panel6.TabIndex = 13;
            // 
            // primming
            // 
            primming.AutoSize = true;
            primming.ForeColor = Color.LightGray;
            primming.Location = new Point(25, 95);
            primming.Name = "primming";
            primming.Size = new Size(60, 22);
            primming.TabIndex = 15;
            primming.Text = "Грунт";
            primming.UseVisualStyleBackColor = true;
            // 
            // gravel
            // 
            gravel.AutoSize = true;
            gravel.ForeColor = Color.LightGray;
            gravel.Location = new Point(25, 67);
            gravel.Name = "gravel";
            gravel.Size = new Size(69, 22);
            gravel.TabIndex = 13;
            gravel.Text = "Гравий";
            gravel.UseVisualStyleBackColor = true;
            // 
            // asphalt
            // 
            asphalt.AutoSize = true;
            asphalt.Checked = true;
            asphalt.ForeColor = Color.LightGray;
            asphalt.Location = new Point(25, 39);
            asphalt.Name = "asphalt";
            asphalt.Size = new Size(77, 22);
            asphalt.TabIndex = 12;
            asphalt.TabStop = true;
            asphalt.Text = "Асфальт";
            asphalt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(4, 9);
            label4.Name = "label4";
            label4.Size = new Size(192, 18);
            label4.TabIndex = 11;
            label4.Text = "Дорожное покрытие";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(brackingDistanceField);
            panel2.Controls.Add(calculate);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(206, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 499);
            panel2.TabIndex = 1;
            // 
            // brackingDistanceField
            // 
            brackingDistanceField.Anchor = AnchorStyles.None;
            brackingDistanceField.BackColor = Color.Black;
            brackingDistanceField.BorderStyle = BorderStyle.None;
            brackingDistanceField.ForeColor = Color.LightGray;
            brackingDistanceField.Location = new Point(80, 38);
            brackingDistanceField.Multiline = true;
            brackingDistanceField.Name = "brackingDistanceField";
            brackingDistanceField.Size = new Size(676, 51);
            brackingDistanceField.TabIndex = 2;
            brackingDistanceField.TextAlign = HorizontalAlignment.Center;
            // 
            // calculate
            // 
            calculate.FlatStyle = FlatStyle.Flat;
            calculate.ForeColor = Color.LightGray;
            calculate.Location = new Point(0, 440);
            calculate.Name = "calculate";
            calculate.Size = new Size(189, 55);
            calculate.TabIndex = 0;
            calculate.Text = "Рассчитать";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1054, 499);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Расчет тормозного пути";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private RadioButton skinTires;
        private RadioButton winterTires;
        private RadioButton summerTires;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private RadioButton weather_ice;
        private RadioButton weather_dry;
        private RadioButton weather_rain;
        private RadioButton weather_snow;
        private Panel panel6;
        private RadioButton primming;
        private RadioButton gravel;
        private RadioButton asphalt;
        private Label label4;
        private Button calculate;
        private TextBox brackingDistanceField;
    }
}