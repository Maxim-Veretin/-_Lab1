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
            this.GrayImageBut = new System.Windows.Forms.Button();
            this.ShowOriginImgBut = new System.Windows.Forms.Button();
            this.cannyThresholdScrl = new System.Windows.Forms.TrackBar();
            this.cannyThresholdLinkingScrl = new System.Windows.Forms.TrackBar();
            this.KannyFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxFlatColors = new System.Windows.Forms.CheckBox();
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
            // GrayImageBut
            // 
            this.GrayImageBut.Location = new System.Drawing.Point(118, 499);
            this.GrayImageBut.Name = "GrayImageBut";
            this.GrayImageBut.Size = new System.Drawing.Size(100, 29);
            this.GrayImageBut.TabIndex = 5;
            this.GrayImageBut.Text = "Gray Image";
            this.GrayImageBut.UseVisualStyleBackColor = true;
            this.GrayImageBut.Click += new System.EventHandler(this.GrayImageBut_Click);
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
            this.cannyThresholdScrl.Scroll += new System.EventHandler(this.cannyThresholdScrl_Scroll);
            // 
            // cannyThresholdLinkingScrl
            // 
            this.cannyThresholdLinkingScrl.Location = new System.Drawing.Point(118, 585);
            this.cannyThresholdLinkingScrl.Maximum = 255;
            this.cannyThresholdLinkingScrl.Name = "cannyThresholdLinkingScrl";
            this.cannyThresholdLinkingScrl.Size = new System.Drawing.Size(1195, 45);
            this.cannyThresholdLinkingScrl.TabIndex = 8;
            this.cannyThresholdLinkingScrl.Value = 30;
            this.cannyThresholdLinkingScrl.Scroll += new System.EventHandler(this.cannyThresholdLinkingScrl_Scroll);
            // 
            // KannyFilterCheckBox
            // 
            this.KannyFilterCheckBox.AutoSize = true;
            this.KannyFilterCheckBox.Location = new System.Drawing.Point(224, 506);
            this.KannyFilterCheckBox.Name = "KannyFilterCheckBox";
            this.KannyFilterCheckBox.Size = new System.Drawing.Size(81, 17);
            this.KannyFilterCheckBox.TabIndex = 9;
            this.KannyFilterCheckBox.Text = "Kanny Filter";
            this.KannyFilterCheckBox.UseVisualStyleBackColor = true;
            this.KannyFilterCheckBox.CheckedChanged += new System.EventHandler(this.KannyFilterCheckBox_CheckedChanged);
            // 
            // checkBoxFlatColors
            // 
            this.checkBoxFlatColors.AutoSize = true;
            this.checkBoxFlatColors.Location = new System.Drawing.Point(311, 506);
            this.checkBoxFlatColors.Name = "checkBoxFlatColors";
            this.checkBoxFlatColors.Size = new System.Drawing.Size(75, 17);
            this.checkBoxFlatColors.TabIndex = 10;
            this.checkBoxFlatColors.Text = "Flat Colors";
            this.checkBoxFlatColors.UseVisualStyleBackColor = true;
            this.checkBoxFlatColors.CheckedChanged += new System.EventHandler(this.checkBoxFlatColors_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 639);
            this.Controls.Add(this.checkBoxFlatColors);
            this.Controls.Add(this.KannyFilterCheckBox);
            this.Controls.Add(this.cannyThresholdLinkingScrl);
            this.Controls.Add(this.cannyThresholdScrl);
            this.Controls.Add(this.ShowOriginImgBut);
            this.Controls.Add(this.GrayImageBut);
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
        private System.Windows.Forms.Button GrayImageBut;
        private System.Windows.Forms.Button ShowOriginImgBut;
        private System.Windows.Forms.TrackBar cannyThresholdScrl;
        private System.Windows.Forms.TrackBar cannyThresholdLinkingScrl;
        private System.Windows.Forms.CheckBox KannyFilterCheckBox;
        private System.Windows.Forms.CheckBox checkBoxFlatColors;
    }
}

