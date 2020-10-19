namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sourseImgBox = new Emgu.CV.UI.ImageBox();
            this.LoadImageBut = new System.Windows.Forms.Button();
            this.resultImgBox = new Emgu.CV.UI.ImageBox();
            this.ShowOriginImgBut = new System.Windows.Forms.Button();
            this.cannyThresholdScrl = new System.Windows.Forms.TrackBar();
            this.cannyThresholdLinkingScrl = new System.Windows.Forms.TrackBar();
            this.CannyFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.FlatColorsCheckBox = new System.Windows.Forms.CheckBox();
            this.LoadVideoBut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sourseImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThresholdScrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThresholdLinkingScrl)).BeginInit();
            this.SuspendLayout();
            // 
            // sourseImgBox
            // 
            this.sourseImgBox.Location = new System.Drawing.Point(12, 12);
            this.sourseImgBox.Name = "sourseImgBox";
            this.sourseImgBox.Size = new System.Drawing.Size(640, 480);
            this.sourseImgBox.TabIndex = 2;
            this.sourseImgBox.TabStop = false;
            // 
            // LoadImageBut
            // 
            this.LoadImageBut.Location = new System.Drawing.Point(12, 498);
            this.LoadImageBut.Name = "LoadImageBut";
            this.LoadImageBut.Size = new System.Drawing.Size(100, 30);
            this.LoadImageBut.TabIndex = 3;
            this.LoadImageBut.Text = "Load Image";
            this.LoadImageBut.UseVisualStyleBackColor = true;
            this.LoadImageBut.Click += new System.EventHandler(this.LoadImageBut_Click);
            // 
            // resultImgBox
            // 
            this.resultImgBox.Location = new System.Drawing.Point(673, 12);
            this.resultImgBox.Name = "resultImgBox";
            this.resultImgBox.Size = new System.Drawing.Size(640, 480);
            this.resultImgBox.TabIndex = 2;
            this.resultImgBox.TabStop = false;
            // 
            // ShowOriginImgBut
            // 
            this.ShowOriginImgBut.Location = new System.Drawing.Point(12, 534);
            this.ShowOriginImgBut.Name = "ShowOriginImgBut";
            this.ShowOriginImgBut.Size = new System.Drawing.Size(100, 45);
            this.ShowOriginImgBut.TabIndex = 6;
            this.ShowOriginImgBut.Text = "Show Origin Image";
            this.ShowOriginImgBut.UseVisualStyleBackColor = true;
            this.ShowOriginImgBut.Click += new System.EventHandler(this.ShowOriginImgBut_Click);
            // 
            // cannyThresholdScrl
            // 
            this.cannyThresholdScrl.Location = new System.Drawing.Point(118, 534);
            this.cannyThresholdScrl.Maximum = 255;
            this.cannyThresholdScrl.Name = "cannyThresholdScrl";
            this.cannyThresholdScrl.Size = new System.Drawing.Size(1195, 45);
            this.cannyThresholdScrl.TabIndex = 7;
            this.cannyThresholdScrl.Value = 20;
            this.cannyThresholdScrl.Scroll += new System.EventHandler(this.CannyThresholdScrl_Scroll);
            // 
            // cannyThresholdLinkingScrl
            // 
            this.cannyThresholdLinkingScrl.Location = new System.Drawing.Point(118, 585);
            this.cannyThresholdLinkingScrl.Maximum = 255;
            this.cannyThresholdLinkingScrl.Name = "cannyThresholdLinkingScrl";
            this.cannyThresholdLinkingScrl.Size = new System.Drawing.Size(1195, 45);
            this.cannyThresholdLinkingScrl.TabIndex = 8;
            this.cannyThresholdLinkingScrl.Value = 30;
            this.cannyThresholdLinkingScrl.Scroll += new System.EventHandler(this.CannyThresholdLinkingScrl_Scroll);
            // 
            // CannyFilterCheckBox
            // 
            this.CannyFilterCheckBox.AutoSize = true;
            this.CannyFilterCheckBox.Location = new System.Drawing.Point(123, 506);
            this.CannyFilterCheckBox.Name = "CannyFilterCheckBox";
            this.CannyFilterCheckBox.Size = new System.Drawing.Size(81, 17);
            this.CannyFilterCheckBox.TabIndex = 9;
            this.CannyFilterCheckBox.Text = "Canny Filter";
            this.CannyFilterCheckBox.UseVisualStyleBackColor = true;
            this.CannyFilterCheckBox.CheckedChanged += new System.EventHandler(this.CannyFilterCheckBox_CheckedChanged);
            // 
            // FlatColorsCheckBox
            // 
            this.FlatColorsCheckBox.AutoSize = true;
            this.FlatColorsCheckBox.Location = new System.Drawing.Point(210, 506);
            this.FlatColorsCheckBox.Name = "FlatColorsCheckBox";
            this.FlatColorsCheckBox.Size = new System.Drawing.Size(75, 17);
            this.FlatColorsCheckBox.TabIndex = 10;
            this.FlatColorsCheckBox.Text = "Flat Colors";
            this.FlatColorsCheckBox.UseVisualStyleBackColor = true;
            this.FlatColorsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxFlatColors_CheckedChanged);
            // 
            // LoadVideoBut
            // 
            this.LoadVideoBut.Location = new System.Drawing.Point(12, 588);
            this.LoadVideoBut.Name = "LoadVideoBut";
            this.LoadVideoBut.Size = new System.Drawing.Size(100, 42);
            this.LoadVideoBut.TabIndex = 11;
            this.LoadVideoBut.Text = "Load Video";
            this.LoadVideoBut.UseVisualStyleBackColor = true;
            this.LoadVideoBut.Click += new System.EventHandler(this.LoadVideoBut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 639);
            this.Controls.Add(this.LoadVideoBut);
            this.Controls.Add(this.FlatColorsCheckBox);
            this.Controls.Add(this.CannyFilterCheckBox);
            this.Controls.Add(this.cannyThresholdLinkingScrl);
            this.Controls.Add(this.cannyThresholdScrl);
            this.Controls.Add(this.ShowOriginImgBut);
            this.Controls.Add(this.resultImgBox);
            this.Controls.Add(this.LoadImageBut);
            this.Controls.Add(this.sourseImgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sourseImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThresholdScrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyThresholdLinkingScrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox sourseImgBox;
        private System.Windows.Forms.Button LoadImageBut;
        private Emgu.CV.UI.ImageBox resultImgBox;
        private System.Windows.Forms.Button ShowOriginImgBut;
        private System.Windows.Forms.TrackBar cannyThresholdScrl;
        private System.Windows.Forms.TrackBar cannyThresholdLinkingScrl;
        private System.Windows.Forms.CheckBox CannyFilterCheckBox;
        private System.Windows.Forms.CheckBox FlatColorsCheckBox;
        private System.Windows.Forms.Button LoadVideoBut;
        private System.Windows.Forms.Timer timer1;
    }
}

